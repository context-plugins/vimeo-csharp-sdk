using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class UploadVideoAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private UploadVideoAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static UploadVideoAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static UploadVideoAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<UploadVideoAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UploadVideoAlt1ErrorResponse : IErrorResponse<UploadVideoAlt1Error>
{
    public static UploadVideoAlt1ErrorResponse Instance { get; } = new();

    private UploadVideoAlt1ErrorResponse()
    {
    }

    public Task<UploadVideoAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        UploadVideoAlt1Error.Create(response, ct);
}

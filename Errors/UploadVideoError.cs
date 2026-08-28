using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class UploadVideoError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private UploadVideoError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static UploadVideoError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static UploadVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<UploadVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UploadVideoErrorResponse : IErrorResponse<UploadVideoError>
{
    public static UploadVideoErrorResponse Instance { get; } = new();

    private UploadVideoErrorResponse()
    {
    }

    public Task<UploadVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UploadVideoError.Create(response, ct);
}

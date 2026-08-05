using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class SetVideoAsShowcaseThumbnailError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SetVideoAsShowcaseThumbnailError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SetVideoAsShowcaseThumbnailError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SetVideoAsShowcaseThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SetVideoAsShowcaseThumbnailError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetVideoAsShowcaseThumbnailErrorResponse : IErrorResponse<SetVideoAsShowcaseThumbnailError>
{
    public static SetVideoAsShowcaseThumbnailErrorResponse Instance { get; } = new();

    private SetVideoAsShowcaseThumbnailErrorResponse()
    {
    }

    public Task<SetVideoAsShowcaseThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetVideoAsShowcaseThumbnailError.Create(response, ct);
}

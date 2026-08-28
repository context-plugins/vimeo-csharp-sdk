using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventThumbnailError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventThumbnailError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventThumbnailError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventThumbnailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventThumbnailErrorResponse : IErrorResponse<GetLiveEventThumbnailError>
{
    public static GetLiveEventThumbnailErrorResponse Instance { get; } = new();

    private GetLiveEventThumbnailErrorResponse()
    {
    }

    public Task<GetLiveEventThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventThumbnailError.Create(response, ct);
}

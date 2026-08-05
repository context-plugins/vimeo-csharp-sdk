using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetLiveEventThumbnailsAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventThumbnailsAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventThumbnailsAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventThumbnailsAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventThumbnailsAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventThumbnailsAlt2ErrorResponse : IErrorResponse<GetLiveEventThumbnailsAlt2Error>
{
    public static GetLiveEventThumbnailsAlt2ErrorResponse Instance { get; } = new();

    private GetLiveEventThumbnailsAlt2ErrorResponse()
    {
    }

    public Task<GetLiveEventThumbnailsAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventThumbnailsAlt2Error.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventThumbnailAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventThumbnailAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventThumbnailAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventThumbnailAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventThumbnailAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventThumbnailAlt2ErrorResponse : IErrorResponse<GetLiveEventThumbnailAlt2Error>
{
    public static GetLiveEventThumbnailAlt2ErrorResponse Instance { get; } = new();

    private GetLiveEventThumbnailAlt2ErrorResponse()
    {
    }

    public Task<GetLiveEventThumbnailAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventThumbnailAlt2Error.Create(response, ct);
}

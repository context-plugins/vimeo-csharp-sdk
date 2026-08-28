using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventM3U8PlaybackError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventM3U8PlaybackError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventM3U8PlaybackError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventM3U8PlaybackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventM3U8PlaybackError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 500 or 503 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventM3U8PlaybackErrorResponse : IErrorResponse<GetLiveEventM3U8PlaybackError>
{
    public static GetLiveEventM3U8PlaybackErrorResponse Instance { get; } = new();

    private GetLiveEventM3U8PlaybackErrorResponse()
    {
    }

    public Task<GetLiveEventM3U8PlaybackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventM3U8PlaybackError.Create(response, ct);
}

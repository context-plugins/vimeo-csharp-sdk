using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetLiveEventThumbnailsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventThumbnailsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventThumbnailsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventThumbnailsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventThumbnailsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventThumbnailsErrorResponse : IErrorResponse<GetLiveEventThumbnailsError>
{
    public static GetLiveEventThumbnailsErrorResponse Instance { get; } = new();

    private GetLiveEventThumbnailsErrorResponse()
    {
    }

    public Task<GetLiveEventThumbnailsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventThumbnailsError.Create(response, ct);
}

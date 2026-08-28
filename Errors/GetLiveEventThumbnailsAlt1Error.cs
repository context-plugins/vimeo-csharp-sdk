using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventThumbnailsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventThumbnailsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventThumbnailsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventThumbnailsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventThumbnailsAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventThumbnailsAlt1ErrorResponse : IErrorResponse<GetLiveEventThumbnailsAlt1Error>
{
    public static GetLiveEventThumbnailsAlt1ErrorResponse Instance { get; } = new();

    private GetLiveEventThumbnailsAlt1ErrorResponse()
    {
    }

    public Task<GetLiveEventThumbnailsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventThumbnailsAlt1Error.Create(response, ct);
}

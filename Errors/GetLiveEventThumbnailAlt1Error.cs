using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventThumbnailAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventThumbnailAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventThumbnailAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventThumbnailAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventThumbnailAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventThumbnailAlt1ErrorResponse : IErrorResponse<GetLiveEventThumbnailAlt1Error>
{
    public static GetLiveEventThumbnailAlt1ErrorResponse Instance { get; } = new();

    private GetLiveEventThumbnailAlt1ErrorResponse()
    {
    }

    public Task<GetLiveEventThumbnailAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventThumbnailAlt1Error.Create(response, ct);
}

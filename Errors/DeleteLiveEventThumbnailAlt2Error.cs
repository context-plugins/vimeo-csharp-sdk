using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteLiveEventThumbnailAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventThumbnailAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventThumbnailAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventThumbnailAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventThumbnailAlt2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventThumbnailAlt2ErrorResponse : IErrorResponse<DeleteLiveEventThumbnailAlt2Error>
{
    public static DeleteLiveEventThumbnailAlt2ErrorResponse Instance { get; } = new();

    private DeleteLiveEventThumbnailAlt2ErrorResponse()
    {
    }

    public Task<DeleteLiveEventThumbnailAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventThumbnailAlt2Error.Create(response, ct);
}

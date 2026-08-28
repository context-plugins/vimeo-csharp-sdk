using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteLiveEventThumbnailAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventThumbnailAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventThumbnailAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventThumbnailAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventThumbnailAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventThumbnailAlt1ErrorResponse : IErrorResponse<DeleteLiveEventThumbnailAlt1Error>
{
    public static DeleteLiveEventThumbnailAlt1ErrorResponse Instance { get; } = new();

    private DeleteLiveEventThumbnailAlt1ErrorResponse()
    {
    }

    public Task<DeleteLiveEventThumbnailAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventThumbnailAlt1Error.Create(response, ct);
}

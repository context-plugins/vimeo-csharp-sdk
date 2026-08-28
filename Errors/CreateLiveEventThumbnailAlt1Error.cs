using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateLiveEventThumbnailAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateLiveEventThumbnailAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateLiveEventThumbnailAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateLiveEventThumbnailAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateLiveEventThumbnailAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateLiveEventThumbnailAlt1ErrorResponse : IErrorResponse<CreateLiveEventThumbnailAlt1Error>
{
    public static CreateLiveEventThumbnailAlt1ErrorResponse Instance { get; } = new();

    private CreateLiveEventThumbnailAlt1ErrorResponse()
    {
    }

    public Task<CreateLiveEventThumbnailAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateLiveEventThumbnailAlt1Error.Create(response, ct);
}

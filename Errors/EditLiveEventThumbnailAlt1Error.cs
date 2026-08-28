using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditLiveEventThumbnailAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditLiveEventThumbnailAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditLiveEventThumbnailAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EditLiveEventThumbnailAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditLiveEventThumbnailAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditLiveEventThumbnailAlt1ErrorResponse : IErrorResponse<EditLiveEventThumbnailAlt1Error>
{
    public static EditLiveEventThumbnailAlt1ErrorResponse Instance { get; } = new();

    private EditLiveEventThumbnailAlt1ErrorResponse()
    {
    }

    public Task<EditLiveEventThumbnailAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditLiveEventThumbnailAlt1Error.Create(response, ct);
}

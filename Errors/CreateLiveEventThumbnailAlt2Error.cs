using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateLiveEventThumbnailAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateLiveEventThumbnailAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateLiveEventThumbnailAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateLiveEventThumbnailAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateLiveEventThumbnailAlt2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateLiveEventThumbnailAlt2ErrorResponse : IErrorResponse<CreateLiveEventThumbnailAlt2Error>
{
    public static CreateLiveEventThumbnailAlt2ErrorResponse Instance { get; } = new();

    private CreateLiveEventThumbnailAlt2ErrorResponse()
    {
    }

    public Task<CreateLiveEventThumbnailAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateLiveEventThumbnailAlt2Error.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateLiveEventThumbnailError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateLiveEventThumbnailError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateLiveEventThumbnailError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateLiveEventThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateLiveEventThumbnailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateLiveEventThumbnailErrorResponse : IErrorResponse<CreateLiveEventThumbnailError>
{
    public static CreateLiveEventThumbnailErrorResponse Instance { get; } = new();

    private CreateLiveEventThumbnailErrorResponse()
    {
    }

    public Task<CreateLiveEventThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateLiveEventThumbnailError.Create(response, ct);
}

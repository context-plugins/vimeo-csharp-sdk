using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EditLiveEventThumbnailAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditLiveEventThumbnailAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditLiveEventThumbnailAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EditLiveEventThumbnailAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditLiveEventThumbnailAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditLiveEventThumbnailAlt2ErrorResponse : IErrorResponse<EditLiveEventThumbnailAlt2Error>
{
    public static EditLiveEventThumbnailAlt2ErrorResponse Instance { get; } = new();

    private EditLiveEventThumbnailAlt2ErrorResponse()
    {
    }

    public Task<EditLiveEventThumbnailAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditLiveEventThumbnailAlt2Error.Create(response, ct);
}

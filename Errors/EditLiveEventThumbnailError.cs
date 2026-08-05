using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EditLiveEventThumbnailError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EditLiveEventThumbnailError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EditLiveEventThumbnailError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static EditLiveEventThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EditLiveEventThumbnailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditLiveEventThumbnailErrorResponse : IErrorResponse<EditLiveEventThumbnailError>
{
    public static EditLiveEventThumbnailErrorResponse Instance { get; } = new();

    private EditLiveEventThumbnailErrorResponse()
    {
    }

    public Task<EditLiveEventThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditLiveEventThumbnailError.Create(response, ct);
}

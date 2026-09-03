using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteLiveEventThumbnailError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventThumbnailError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventThumbnailError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventThumbnailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventThumbnailErrorResponse : IErrorResponse<DeleteLiveEventThumbnailError>
{
    public static DeleteLiveEventThumbnailErrorResponse Instance { get; } = new();

    private DeleteLiveEventThumbnailErrorResponse()
    {
    }

    public Task<DeleteLiveEventThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventThumbnailError.Create(response, ct);
}

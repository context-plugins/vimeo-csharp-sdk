using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AttachGraphicItemToSceneError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AttachGraphicItemToSceneError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AttachGraphicItemToSceneError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AttachGraphicItemToSceneError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AttachGraphicItemToSceneError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AttachGraphicItemToSceneErrorResponse : IErrorResponse<AttachGraphicItemToSceneError>
{
    public static AttachGraphicItemToSceneErrorResponse Instance { get; } = new();

    private AttachGraphicItemToSceneErrorResponse()
    {
    }

    public Task<AttachGraphicItemToSceneError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AttachGraphicItemToSceneError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateComposerSceneError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateComposerSceneError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateComposerSceneError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateComposerSceneError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateComposerSceneError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateComposerSceneErrorResponse : IErrorResponse<CreateComposerSceneError>
{
    public static CreateComposerSceneErrorResponse Instance { get; } = new();

    private CreateComposerSceneErrorResponse()
    {
    }

    public Task<CreateComposerSceneError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateComposerSceneError.Create(response, ct);
}

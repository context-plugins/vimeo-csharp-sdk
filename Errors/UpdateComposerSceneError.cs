using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class UpdateComposerSceneError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private UpdateComposerSceneError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static UpdateComposerSceneError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static UpdateComposerSceneError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<UpdateComposerSceneError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UpdateComposerSceneErrorResponse : IErrorResponse<UpdateComposerSceneError>
{
    public static UpdateComposerSceneErrorResponse Instance { get; } = new();

    private UpdateComposerSceneErrorResponse()
    {
    }

    public Task<UpdateComposerSceneError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UpdateComposerSceneError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class ResetComposerScenesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ResetComposerScenesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ResetComposerScenesError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ResetComposerScenesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ResetComposerScenesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ResetComposerScenesErrorResponse : IErrorResponse<ResetComposerScenesError>
{
    public static ResetComposerScenesErrorResponse Instance { get; } = new();

    private ResetComposerScenesErrorResponse()
    {
    }

    public Task<ResetComposerScenesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ResetComposerScenesError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetComposerScenesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetComposerScenesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetComposerScenesError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetComposerScenesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetComposerScenesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetComposerScenesErrorResponse : IErrorResponse<GetComposerScenesError>
{
    public static GetComposerScenesErrorResponse Instance { get; } = new();

    private GetComposerScenesErrorResponse()
    {
    }

    public Task<GetComposerScenesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetComposerScenesError.Create(response, ct);
}

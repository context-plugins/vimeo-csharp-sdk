using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EndLiveEventError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EndLiveEventError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EndLiveEventError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static EndLiveEventError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EndLiveEventError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EndLiveEventErrorResponse : IErrorResponse<EndLiveEventError>
{
    public static EndLiveEventErrorResponse Instance { get; } = new();

    private EndLiveEventErrorResponse()
    {
    }

    public Task<EndLiveEventError> Map(HttpResponseMessage response, CancellationToken ct) =>
        EndLiveEventError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class EndLiveEventAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private EndLiveEventAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static EndLiveEventAlt2Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static EndLiveEventAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<EndLiveEventAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EndLiveEventAlt2ErrorResponse : IErrorResponse<EndLiveEventAlt2Error>
{
    public static EndLiveEventAlt2ErrorResponse Instance { get; } = new();

    private EndLiveEventAlt2ErrorResponse()
    {
    }

    public Task<EndLiveEventAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        EndLiveEventAlt2Error.Create(response, ct);
}

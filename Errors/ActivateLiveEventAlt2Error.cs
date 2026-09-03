using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ActivateLiveEventAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ActivateLiveEventAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ActivateLiveEventAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static ActivateLiveEventAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ActivateLiveEventAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 500 or 503 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ActivateLiveEventAlt2ErrorResponse : IErrorResponse<ActivateLiveEventAlt2Error>
{
    public static ActivateLiveEventAlt2ErrorResponse Instance { get; } = new();

    private ActivateLiveEventAlt2ErrorResponse()
    {
    }

    public Task<ActivateLiveEventAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ActivateLiveEventAlt2Error.Create(response, ct);
}

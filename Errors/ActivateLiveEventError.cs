using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ActivateLiveEventError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ActivateLiveEventError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ActivateLiveEventError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static ActivateLiveEventError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ActivateLiveEventError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 500 or 503 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ActivateLiveEventErrorResponse : IErrorResponse<ActivateLiveEventError>
{
    public static ActivateLiveEventErrorResponse Instance { get; } = new();

    private ActivateLiveEventErrorResponse()
    {
    }

    public Task<ActivateLiveEventError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ActivateLiveEventError.Create(response, ct);
}

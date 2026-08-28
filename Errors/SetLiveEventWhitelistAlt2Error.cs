using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class SetLiveEventWhitelistAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private SetLiveEventWhitelistAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static SetLiveEventWhitelistAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static SetLiveEventWhitelistAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<SetLiveEventWhitelistAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetLiveEventWhitelistAlt2ErrorResponse : IErrorResponse<SetLiveEventWhitelistAlt2Error>
{
    public static SetLiveEventWhitelistAlt2ErrorResponse Instance { get; } = new();

    private SetLiveEventWhitelistAlt2ErrorResponse()
    {
    }

    public Task<SetLiveEventWhitelistAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetLiveEventWhitelistAlt2Error.Create(response, ct);
}

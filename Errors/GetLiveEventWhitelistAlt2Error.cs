using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventWhitelistAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventWhitelistAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventWhitelistAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventWhitelistAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventWhitelistAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventWhitelistAlt2ErrorResponse : IErrorResponse<GetLiveEventWhitelistAlt2Error>
{
    public static GetLiveEventWhitelistAlt2ErrorResponse Instance { get; } = new();

    private GetLiveEventWhitelistAlt2ErrorResponse()
    {
    }

    public Task<GetLiveEventWhitelistAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventWhitelistAlt2Error.Create(response, ct);
}

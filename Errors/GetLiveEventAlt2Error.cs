using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetLiveEventAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventAlt2Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetLiveEventAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventAlt2ErrorResponse : IErrorResponse<GetLiveEventAlt2Error>
{
    public static GetLiveEventAlt2ErrorResponse Instance { get; } = new();

    private GetLiveEventAlt2ErrorResponse()
    {
    }

    public Task<GetLiveEventAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventAlt2Error.Create(response, ct);
}

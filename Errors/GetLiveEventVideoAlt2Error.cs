using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventVideoAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventVideoAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventVideoAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventVideoAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventVideoAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventVideoAlt2ErrorResponse : IErrorResponse<GetLiveEventVideoAlt2Error>
{
    public static GetLiveEventVideoAlt2ErrorResponse Instance { get; } = new();

    private GetLiveEventVideoAlt2ErrorResponse()
    {
    }

    public Task<GetLiveEventVideoAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventVideoAlt2Error.Create(response, ct);
}

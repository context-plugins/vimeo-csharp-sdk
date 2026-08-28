using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventVideosAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventVideosAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventVideosAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventVideosAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventVideosAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventVideosAlt2ErrorResponse : IErrorResponse<GetLiveEventVideosAlt2Error>
{
    public static GetLiveEventVideosAlt2ErrorResponse Instance { get; } = new();

    private GetLiveEventVideosAlt2ErrorResponse()
    {
    }

    public Task<GetLiveEventVideosAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventVideosAlt2Error.Create(response, ct);
}

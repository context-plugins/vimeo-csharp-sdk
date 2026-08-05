using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetLiveEventVideosError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventVideosError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventVideosError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventVideosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventVideosError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventVideosErrorResponse : IErrorResponse<GetLiveEventVideosError>
{
    public static GetLiveEventVideosErrorResponse Instance { get; } = new();

    private GetLiveEventVideosErrorResponse()
    {
    }

    public Task<GetLiveEventVideosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventVideosError.Create(response, ct);
}

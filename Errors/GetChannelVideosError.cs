using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetChannelVideosError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetChannelVideosError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetChannelVideosError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetChannelVideosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetChannelVideosError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChannelVideosErrorResponse : IErrorResponse<GetChannelVideosError>
{
    public static GetChannelVideosErrorResponse Instance { get; } = new();

    private GetChannelVideosErrorResponse()
    {
    }

    public Task<GetChannelVideosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChannelVideosError.Create(response, ct);
}

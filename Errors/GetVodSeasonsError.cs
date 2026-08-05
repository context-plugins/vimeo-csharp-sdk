using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVodSeasonsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodSeasonsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodSeasonsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodSeasonsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodSeasonsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodSeasonsErrorResponse : IErrorResponse<GetVodSeasonsError>
{
    public static GetVodSeasonsErrorResponse Instance { get; } = new();

    private GetVodSeasonsErrorResponse()
    {
    }

    public Task<GetVodSeasonsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodSeasonsError.Create(response, ct);
}

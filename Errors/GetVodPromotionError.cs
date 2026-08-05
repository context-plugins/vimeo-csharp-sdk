using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVodPromotionError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodPromotionError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodPromotionError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodPromotionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodPromotionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodPromotionErrorResponse : IErrorResponse<GetVodPromotionError>
{
    public static GetVodPromotionErrorResponse Instance { get; } = new();

    private GetVodPromotionErrorResponse()
    {
    }

    public Task<GetVodPromotionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodPromotionError.Create(response, ct);
}

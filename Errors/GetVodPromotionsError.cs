using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVodPromotionsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodPromotionsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodPromotionsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodPromotionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodPromotionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodPromotionsErrorResponse : IErrorResponse<GetVodPromotionsError>
{
    public static GetVodPromotionsErrorResponse Instance { get; } = new();

    private GetVodPromotionsErrorResponse()
    {
    }

    public Task<GetVodPromotionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodPromotionsError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVodPromotionError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteVodPromotionError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteVodPromotionError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteVodPromotionError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteVodPromotionError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVodPromotionErrorResponse : IErrorResponse<DeleteVodPromotionError>
{
    public static DeleteVodPromotionErrorResponse Instance { get; } = new();

    private DeleteVodPromotionErrorResponse()
    {
    }

    public Task<DeleteVodPromotionError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVodPromotionError.Create(response, ct);
}

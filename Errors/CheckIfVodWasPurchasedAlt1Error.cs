using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CheckIfVodWasPurchasedAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfVodWasPurchasedAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfVodWasPurchasedAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfVodWasPurchasedAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfVodWasPurchasedAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfVodWasPurchasedAlt1ErrorResponse : IErrorResponse<CheckIfVodWasPurchasedAlt1Error>
{
    public static CheckIfVodWasPurchasedAlt1ErrorResponse Instance { get; } = new();

    private CheckIfVodWasPurchasedAlt1ErrorResponse()
    {
    }

    public Task<CheckIfVodWasPurchasedAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfVodWasPurchasedAlt1Error.Create(response, ct);
}

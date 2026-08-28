using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVodPurchasesAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodPurchasesAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodPurchasesAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodPurchasesAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodPurchasesAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodPurchasesAlt1ErrorResponse : IErrorResponse<GetVodPurchasesAlt1Error>
{
    public static GetVodPurchasesAlt1ErrorResponse Instance { get; } = new();

    private GetVodPurchasesAlt1ErrorResponse()
    {
    }

    public Task<GetVodPurchasesAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodPurchasesAlt1Error.Create(response, ct);
}

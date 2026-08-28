using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVodPurchasesError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodPurchasesError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodPurchasesError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodPurchasesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodPurchasesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodPurchasesErrorResponse : IErrorResponse<GetVodPurchasesError>
{
    public static GetVodPurchasesErrorResponse Instance { get; } = new();

    private GetVodPurchasesErrorResponse()
    {
    }

    public Task<GetVodPurchasesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodPurchasesError.Create(response, ct);
}

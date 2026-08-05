using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CopyShowcaseError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CopyShowcaseError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CopyShowcaseError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CopyShowcaseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CopyShowcaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CopyShowcaseErrorResponse : IErrorResponse<CopyShowcaseError>
{
    public static CopyShowcaseErrorResponse Instance { get; } = new();

    private CopyShowcaseErrorResponse()
    {
    }

    public Task<CopyShowcaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CopyShowcaseError.Create(response, ct);
}

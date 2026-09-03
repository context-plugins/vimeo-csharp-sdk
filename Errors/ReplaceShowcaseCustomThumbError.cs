using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ReplaceShowcaseCustomThumbError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private ReplaceShowcaseCustomThumbError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static ReplaceShowcaseCustomThumbError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static ReplaceShowcaseCustomThumbError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<ReplaceShowcaseCustomThumbError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ReplaceShowcaseCustomThumbErrorResponse : IErrorResponse<ReplaceShowcaseCustomThumbError>
{
    public static ReplaceShowcaseCustomThumbErrorResponse Instance { get; } = new();

    private ReplaceShowcaseCustomThumbErrorResponse()
    {
    }

    public Task<ReplaceShowcaseCustomThumbError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ReplaceShowcaseCustomThumbError.Create(response, ct);
}

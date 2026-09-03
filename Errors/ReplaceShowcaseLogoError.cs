using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ReplaceShowcaseLogoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private ReplaceShowcaseLogoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static ReplaceShowcaseLogoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static ReplaceShowcaseLogoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<ReplaceShowcaseLogoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ReplaceShowcaseLogoErrorResponse : IErrorResponse<ReplaceShowcaseLogoError>
{
    public static ReplaceShowcaseLogoErrorResponse Instance { get; } = new();

    private ReplaceShowcaseLogoErrorResponse()
    {
    }

    public Task<ReplaceShowcaseLogoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ReplaceShowcaseLogoError.Create(response, ct);
}

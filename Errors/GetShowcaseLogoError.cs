using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetShowcaseLogoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcaseLogoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcaseLogoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcaseLogoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcaseLogoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcaseLogoErrorResponse : IErrorResponse<GetShowcaseLogoError>
{
    public static GetShowcaseLogoErrorResponse Instance { get; } = new();

    private GetShowcaseLogoErrorResponse()
    {
    }

    public Task<GetShowcaseLogoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcaseLogoError.Create(response, ct);
}

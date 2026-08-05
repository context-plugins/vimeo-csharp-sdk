using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVodBackgroundError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodBackgroundError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodBackgroundError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodBackgroundError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodBackgroundError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodBackgroundErrorResponse : IErrorResponse<GetVodBackgroundError>
{
    public static GetVodBackgroundErrorResponse Instance { get; } = new();

    private GetVodBackgroundErrorResponse()
    {
    }

    public Task<GetVodBackgroundError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodBackgroundError.Create(response, ct);
}

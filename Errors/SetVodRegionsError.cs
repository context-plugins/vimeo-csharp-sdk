using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class SetVodRegionsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private SetVodRegionsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static SetVodRegionsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static SetVodRegionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<SetVodRegionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetVodRegionsErrorResponse : IErrorResponse<SetVodRegionsError>
{
    public static SetVodRegionsErrorResponse Instance { get; } = new();

    private SetVodRegionsErrorResponse()
    {
    }

    public Task<SetVodRegionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetVodRegionsError.Create(response, ct);
}

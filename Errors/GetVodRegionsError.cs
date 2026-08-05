using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetVodRegionsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodRegionsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodRegionsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodRegionsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodRegionsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodRegionsErrorResponse : IErrorResponse<GetVodRegionsError>
{
    public static GetVodRegionsErrorResponse Instance { get; } = new();

    private GetVodRegionsErrorResponse()
    {
    }

    public Task<GetVodRegionsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodRegionsError.Create(response, ct);
}

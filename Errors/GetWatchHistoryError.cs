using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetWatchHistoryError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetWatchHistoryError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetWatchHistoryError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetWatchHistoryError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetWatchHistoryError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetWatchHistoryErrorResponse : IErrorResponse<GetWatchHistoryError>
{
    public static GetWatchHistoryErrorResponse Instance { get; } = new();

    private GetWatchHistoryErrorResponse()
    {
    }

    public Task<GetWatchHistoryError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetWatchHistoryError.Create(response, ct);
}

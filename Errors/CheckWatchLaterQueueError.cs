using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CheckWatchLaterQueueError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckWatchLaterQueueError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckWatchLaterQueueError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckWatchLaterQueueError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckWatchLaterQueueError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckWatchLaterQueueErrorResponse : IErrorResponse<CheckWatchLaterQueueError>
{
    public static CheckWatchLaterQueueErrorResponse Instance { get; } = new();

    private CheckWatchLaterQueueErrorResponse()
    {
    }

    public Task<CheckWatchLaterQueueError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckWatchLaterQueueError.Create(response, ct);
}

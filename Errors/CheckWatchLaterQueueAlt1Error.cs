using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CheckWatchLaterQueueAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckWatchLaterQueueAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckWatchLaterQueueAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckWatchLaterQueueAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckWatchLaterQueueAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckWatchLaterQueueAlt1ErrorResponse : IErrorResponse<CheckWatchLaterQueueAlt1Error>
{
    public static CheckWatchLaterQueueAlt1ErrorResponse Instance { get; } = new();

    private CheckWatchLaterQueueAlt1ErrorResponse()
    {
    }

    public Task<CheckWatchLaterQueueAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckWatchLaterQueueAlt1Error.Create(response, ct);
}

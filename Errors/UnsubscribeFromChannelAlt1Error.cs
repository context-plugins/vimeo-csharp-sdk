using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class UnsubscribeFromChannelAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private UnsubscribeFromChannelAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static UnsubscribeFromChannelAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static UnsubscribeFromChannelAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<UnsubscribeFromChannelAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UnsubscribeFromChannelAlt1ErrorResponse : IErrorResponse<UnsubscribeFromChannelAlt1Error>
{
    public static UnsubscribeFromChannelAlt1ErrorResponse Instance { get; } = new();

    private UnsubscribeFromChannelAlt1ErrorResponse()
    {
    }

    public Task<UnsubscribeFromChannelAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        UnsubscribeFromChannelAlt1Error.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class UnsubscribeFromChannelError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private UnsubscribeFromChannelError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static UnsubscribeFromChannelError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static UnsubscribeFromChannelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<UnsubscribeFromChannelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UnsubscribeFromChannelErrorResponse : IErrorResponse<UnsubscribeFromChannelError>
{
    public static UnsubscribeFromChannelErrorResponse Instance { get; } = new();

    private UnsubscribeFromChannelErrorResponse()
    {
    }

    public Task<UnsubscribeFromChannelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UnsubscribeFromChannelError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class SubscribeToChannelAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private SubscribeToChannelAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static SubscribeToChannelAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static SubscribeToChannelAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<SubscribeToChannelAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscribeToChannelAlt1ErrorResponse : IErrorResponse<SubscribeToChannelAlt1Error>
{
    public static SubscribeToChannelAlt1ErrorResponse Instance { get; } = new();

    private SubscribeToChannelAlt1ErrorResponse()
    {
    }

    public Task<SubscribeToChannelAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubscribeToChannelAlt1Error.Create(response, ct);
}

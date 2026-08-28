using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class SubscribeToChannelError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private SubscribeToChannelError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static SubscribeToChannelError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static SubscribeToChannelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<SubscribeToChannelError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SubscribeToChannelErrorResponse : IErrorResponse<SubscribeToChannelError>
{
    public static SubscribeToChannelErrorResponse Instance { get; } = new();

    private SubscribeToChannelErrorResponse()
    {
    }

    public Task<SubscribeToChannelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SubscribeToChannelError.Create(response, ct);
}

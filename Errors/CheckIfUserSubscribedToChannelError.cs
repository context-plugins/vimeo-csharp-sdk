using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CheckIfUserSubscribedToChannelError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfUserSubscribedToChannelError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfUserSubscribedToChannelError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfUserSubscribedToChannelError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfUserSubscribedToChannelError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfUserSubscribedToChannelErrorResponse : IErrorResponse<CheckIfUserSubscribedToChannelError>
{
    public static CheckIfUserSubscribedToChannelErrorResponse Instance { get; } = new();

    private CheckIfUserSubscribedToChannelErrorResponse()
    {
    }

    public Task<CheckIfUserSubscribedToChannelError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfUserSubscribedToChannelError.Create(response, ct);
}

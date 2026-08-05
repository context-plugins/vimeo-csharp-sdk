using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class FollowUserError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private FollowUserError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static FollowUserError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static FollowUserError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<FollowUserError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FollowUserErrorResponse : IErrorResponse<FollowUserError>
{
    public static FollowUserErrorResponse Instance { get; } = new();

    private FollowUserErrorResponse()
    {
    }

    public Task<FollowUserError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FollowUserError.Create(response, ct);
}

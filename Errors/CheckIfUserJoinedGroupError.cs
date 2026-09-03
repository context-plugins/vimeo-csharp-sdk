using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CheckIfUserJoinedGroupError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfUserJoinedGroupError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfUserJoinedGroupError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfUserJoinedGroupError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfUserJoinedGroupError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfUserJoinedGroupErrorResponse : IErrorResponse<CheckIfUserJoinedGroupError>
{
    public static CheckIfUserJoinedGroupErrorResponse Instance { get; } = new();

    private CheckIfUserJoinedGroupErrorResponse()
    {
    }

    public Task<CheckIfUserJoinedGroupError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfUserJoinedGroupError.Create(response, ct);
}

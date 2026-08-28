using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CheckIfUserIsFollowingError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfUserIsFollowingError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfUserIsFollowingError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfUserIsFollowingError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfUserIsFollowingError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfUserIsFollowingErrorResponse : IErrorResponse<CheckIfUserIsFollowingError>
{
    public static CheckIfUserIsFollowingErrorResponse Instance { get; } = new();

    private CheckIfUserIsFollowingErrorResponse()
    {
    }

    public Task<CheckIfUserIsFollowingError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfUserIsFollowingError.Create(response, ct);
}

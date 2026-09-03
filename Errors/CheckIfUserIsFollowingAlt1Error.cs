using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CheckIfUserIsFollowingAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfUserIsFollowingAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfUserIsFollowingAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfUserIsFollowingAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfUserIsFollowingAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfUserIsFollowingAlt1ErrorResponse : IErrorResponse<CheckIfUserIsFollowingAlt1Error>
{
    public static CheckIfUserIsFollowingAlt1ErrorResponse Instance { get; } = new();

    private CheckIfUserIsFollowingAlt1ErrorResponse()
    {
    }

    public Task<CheckIfUserIsFollowingAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfUserIsFollowingAlt1Error.Create(response, ct);
}

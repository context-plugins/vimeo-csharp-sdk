using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class FollowUserAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private FollowUserAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static FollowUserAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static FollowUserAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<FollowUserAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FollowUserAlt1ErrorResponse : IErrorResponse<FollowUserAlt1Error>
{
    public static FollowUserAlt1ErrorResponse Instance { get; } = new();

    private FollowUserAlt1ErrorResponse()
    {
    }

    public Task<FollowUserAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        FollowUserAlt1Error.Create(response, ct);
}

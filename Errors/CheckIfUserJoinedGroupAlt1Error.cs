using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CheckIfUserJoinedGroupAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CheckIfUserJoinedGroupAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CheckIfUserJoinedGroupAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CheckIfUserJoinedGroupAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CheckIfUserJoinedGroupAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CheckIfUserJoinedGroupAlt1ErrorResponse : IErrorResponse<CheckIfUserJoinedGroupAlt1Error>
{
    public static CheckIfUserJoinedGroupAlt1ErrorResponse Instance { get; } = new();

    private CheckIfUserJoinedGroupAlt1ErrorResponse()
    {
    }

    public Task<CheckIfUserJoinedGroupAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CheckIfUserJoinedGroupAlt1Error.Create(response, ct);
}

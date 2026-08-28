using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class LikeVideoAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private LikeVideoAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static LikeVideoAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static LikeVideoAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<LikeVideoAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class LikeVideoAlt1ErrorResponse : IErrorResponse<LikeVideoAlt1Error>
{
    public static LikeVideoAlt1ErrorResponse Instance { get; } = new();

    private LikeVideoAlt1ErrorResponse()
    {
    }

    public Task<LikeVideoAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        LikeVideoAlt1Error.Create(response, ct);
}

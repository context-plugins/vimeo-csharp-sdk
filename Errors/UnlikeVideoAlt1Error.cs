using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class UnlikeVideoAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private UnlikeVideoAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static UnlikeVideoAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static UnlikeVideoAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<UnlikeVideoAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UnlikeVideoAlt1ErrorResponse : IErrorResponse<UnlikeVideoAlt1Error>
{
    public static UnlikeVideoAlt1ErrorResponse Instance { get; } = new();

    private UnlikeVideoAlt1ErrorResponse()
    {
    }

    public Task<UnlikeVideoAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        UnlikeVideoAlt1Error.Create(response, ct);
}

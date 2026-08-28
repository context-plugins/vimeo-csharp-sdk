using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class UnlikeVideoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private UnlikeVideoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static UnlikeVideoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static UnlikeVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<UnlikeVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class UnlikeVideoErrorResponse : IErrorResponse<UnlikeVideoError>
{
    public static UnlikeVideoErrorResponse Instance { get; } = new();

    private UnlikeVideoErrorResponse()
    {
    }

    public Task<UnlikeVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        UnlikeVideoError.Create(response, ct);
}

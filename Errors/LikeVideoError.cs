using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class LikeVideoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private LikeVideoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static LikeVideoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static LikeVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<LikeVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class LikeVideoErrorResponse : IErrorResponse<LikeVideoError>
{
    public static LikeVideoErrorResponse Instance { get; } = new();

    private LikeVideoErrorResponse()
    {
    }

    public Task<LikeVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        LikeVideoError.Create(response, ct);
}

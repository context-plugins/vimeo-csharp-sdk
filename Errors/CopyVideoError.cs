using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CopyVideoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CopyVideoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CopyVideoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CopyVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CopyVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CopyVideoErrorResponse : IErrorResponse<CopyVideoError>
{
    public static CopyVideoErrorResponse Instance { get; } = new();

    private CopyVideoErrorResponse()
    {
    }

    public Task<CopyVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CopyVideoError.Create(response, ct);
}

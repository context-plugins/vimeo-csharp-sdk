using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class ReplaceVideosInShowcaseAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private ReplaceVideosInShowcaseAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static ReplaceVideosInShowcaseAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static ReplaceVideosInShowcaseAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<ReplaceVideosInShowcaseAlt2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ReplaceVideosInShowcaseAlt2ErrorResponse : IErrorResponse<ReplaceVideosInShowcaseAlt2Error>
{
    public static ReplaceVideosInShowcaseAlt2ErrorResponse Instance { get; } = new();

    private ReplaceVideosInShowcaseAlt2ErrorResponse()
    {
    }

    public Task<ReplaceVideosInShowcaseAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        ReplaceVideosInShowcaseAlt2Error.Create(response, ct);
}

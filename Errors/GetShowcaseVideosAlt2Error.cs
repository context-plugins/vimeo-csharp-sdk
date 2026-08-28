using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetShowcaseVideosAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcaseVideosAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcaseVideosAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcaseVideosAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcaseVideosAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcaseVideosAlt2ErrorResponse : IErrorResponse<GetShowcaseVideosAlt2Error>
{
    public static GetShowcaseVideosAlt2ErrorResponse Instance { get; } = new();

    private GetShowcaseVideosAlt2ErrorResponse()
    {
    }

    public Task<GetShowcaseVideosAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcaseVideosAlt2Error.Create(response, ct);
}

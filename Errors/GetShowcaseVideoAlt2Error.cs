using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetShowcaseVideoAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcaseVideoAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcaseVideoAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcaseVideoAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcaseVideoAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcaseVideoAlt2ErrorResponse : IErrorResponse<GetShowcaseVideoAlt2Error>
{
    public static GetShowcaseVideoAlt2ErrorResponse Instance { get; } = new();

    private GetShowcaseVideoAlt2ErrorResponse()
    {
    }

    public Task<GetShowcaseVideoAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcaseVideoAlt2Error.Create(response, ct);
}

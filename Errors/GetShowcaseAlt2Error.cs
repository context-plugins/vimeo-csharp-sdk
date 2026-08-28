using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetShowcaseAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcaseAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcaseAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcaseAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcaseAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcaseAlt2ErrorResponse : IErrorResponse<GetShowcaseAlt2Error>
{
    public static GetShowcaseAlt2ErrorResponse Instance { get; } = new();

    private GetShowcaseAlt2ErrorResponse()
    {
    }

    public Task<GetShowcaseAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcaseAlt2Error.Create(response, ct);
}

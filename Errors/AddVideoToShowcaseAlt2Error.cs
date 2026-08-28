using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class AddVideoToShowcaseAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private AddVideoToShowcaseAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static AddVideoToShowcaseAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static AddVideoToShowcaseAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<AddVideoToShowcaseAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddVideoToShowcaseAlt2ErrorResponse : IErrorResponse<AddVideoToShowcaseAlt2Error>
{
    public static AddVideoToShowcaseAlt2ErrorResponse Instance { get; } = new();

    private AddVideoToShowcaseAlt2ErrorResponse()
    {
    }

    public Task<AddVideoToShowcaseAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddVideoToShowcaseAlt2Error.Create(response, ct);
}

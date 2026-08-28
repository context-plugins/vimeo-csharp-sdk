using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class EditShowcaseAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private EditShowcaseAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static EditShowcaseAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static EditShowcaseAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<EditShowcaseAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class EditShowcaseAlt2ErrorResponse : IErrorResponse<EditShowcaseAlt2Error>
{
    public static EditShowcaseAlt2ErrorResponse Instance { get; } = new();

    private EditShowcaseAlt2ErrorResponse()
    {
    }

    public Task<EditShowcaseAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        EditShowcaseAlt2Error.Create(response, ct);
}

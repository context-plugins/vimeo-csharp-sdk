using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateShowcaseLogoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateShowcaseLogoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateShowcaseLogoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateShowcaseLogoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateShowcaseLogoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateShowcaseLogoErrorResponse : IErrorResponse<CreateShowcaseLogoError>
{
    public static CreateShowcaseLogoErrorResponse Instance { get; } = new();

    private CreateShowcaseLogoErrorResponse()
    {
    }

    public Task<CreateShowcaseLogoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateShowcaseLogoError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateVideoCustomLogoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateVideoCustomLogoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateVideoCustomLogoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateVideoCustomLogoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateVideoCustomLogoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateVideoCustomLogoErrorResponse : IErrorResponse<CreateVideoCustomLogoError>
{
    public static CreateVideoCustomLogoErrorResponse Instance { get; } = new();

    private CreateVideoCustomLogoErrorResponse()
    {
    }

    public Task<CreateVideoCustomLogoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateVideoCustomLogoError.Create(response, ct);
}

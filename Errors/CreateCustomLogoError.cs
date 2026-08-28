using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateCustomLogoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateCustomLogoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateCustomLogoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateCustomLogoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateCustomLogoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateCustomLogoErrorResponse : IErrorResponse<CreateCustomLogoError>
{
    public static CreateCustomLogoErrorResponse Instance { get; } = new();

    private CreateCustomLogoErrorResponse()
    {
    }

    public Task<CreateCustomLogoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateCustomLogoError.Create(response, ct);
}

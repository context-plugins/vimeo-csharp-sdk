using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateCustomLogoAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateCustomLogoAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateCustomLogoAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateCustomLogoAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateCustomLogoAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateCustomLogoAlt1ErrorResponse : IErrorResponse<CreateCustomLogoAlt1Error>
{
    public static CreateCustomLogoAlt1ErrorResponse Instance { get; } = new();

    private CreateCustomLogoAlt1ErrorResponse()
    {
    }

    public Task<CreateCustomLogoAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateCustomLogoAlt1Error.Create(response, ct);
}

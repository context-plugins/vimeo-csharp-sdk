using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetCustomLogoAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCustomLogoAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCustomLogoAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCustomLogoAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCustomLogoAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCustomLogoAlt1ErrorResponse : IErrorResponse<GetCustomLogoAlt1Error>
{
    public static GetCustomLogoAlt1ErrorResponse Instance { get; } = new();

    private GetCustomLogoAlt1ErrorResponse()
    {
    }

    public Task<GetCustomLogoAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCustomLogoAlt1Error.Create(response, ct);
}

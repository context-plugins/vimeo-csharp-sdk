using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteCustomLogoAlt1Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteCustomLogoAlt1Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteCustomLogoAlt1Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteCustomLogoAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteCustomLogoAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteCustomLogoAlt1ErrorResponse : IErrorResponse<DeleteCustomLogoAlt1Error>
{
    public static DeleteCustomLogoAlt1ErrorResponse Instance { get; } = new();

    private DeleteCustomLogoAlt1ErrorResponse()
    {
    }

    public Task<DeleteCustomLogoAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteCustomLogoAlt1Error.Create(response, ct);
}

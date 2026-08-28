using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteCustomLogoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteCustomLogoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteCustomLogoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteCustomLogoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteCustomLogoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteCustomLogoErrorResponse : IErrorResponse<DeleteCustomLogoError>
{
    public static DeleteCustomLogoErrorResponse Instance { get; } = new();

    private DeleteCustomLogoErrorResponse()
    {
    }

    public Task<DeleteCustomLogoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteCustomLogoError.Create(response, ct);
}

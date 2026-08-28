using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteShowcaseAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private DeleteShowcaseAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static DeleteShowcaseAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static DeleteShowcaseAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<DeleteShowcaseAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteShowcaseAlt2ErrorResponse : IErrorResponse<DeleteShowcaseAlt2Error>
{
    public static DeleteShowcaseAlt2ErrorResponse Instance { get; } = new();

    private DeleteShowcaseAlt2ErrorResponse()
    {
    }

    public Task<DeleteShowcaseAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteShowcaseAlt2Error.Create(response, ct);
}

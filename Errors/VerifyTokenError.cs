using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class VerifyTokenError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private VerifyTokenError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static VerifyTokenError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static VerifyTokenError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<VerifyTokenError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class VerifyTokenErrorResponse : IErrorResponse<VerifyTokenError>
{
    public static VerifyTokenErrorResponse Instance { get; } = new();

    private VerifyTokenErrorResponse()
    {
    }

    public Task<VerifyTokenError> Map(HttpResponseMessage response, CancellationToken ct) =>
        VerifyTokenError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class ExchangeAuthCodeError : ApiError
{
    private readonly Optional<AuthError> _authErrorValue;

    private ExchangeAuthCodeError(Optional<AuthError> authErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _authErrorValue = authErrorValue;
    }

    private static ExchangeAuthCodeError AsAuthError(AuthError value) =>
        new(Optional<AuthError>.Some(value), default);

    private static ExchangeAuthCodeError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetAuthError(out AuthError value) => _authErrorValue.TryGetValue(out value);

    internal static Task<ExchangeAuthCodeError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<AuthError>(response, ct).As(AsAuthError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ExchangeAuthCodeErrorResponse : IErrorResponse<ExchangeAuthCodeError>
{
    public static ExchangeAuthCodeErrorResponse Instance { get; } = new();

    private ExchangeAuthCodeErrorResponse()
    {
    }

    public Task<ExchangeAuthCodeError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ExchangeAuthCodeError.Create(response, ct);
}

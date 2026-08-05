using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ConvertAccessTokenError : ApiError
{
    private readonly Optional<AuthError> _authErrorValue;

    private ConvertAccessTokenError(Optional<AuthError> authErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _authErrorValue = authErrorValue;
    }

    private static ConvertAccessTokenError AsAuthError(AuthError value) =>
        new(Optional<AuthError>.Some(value), default);

    private static ConvertAccessTokenError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetAuthError(out AuthError value) => _authErrorValue.TryGetValue(out value);

    internal static Task<ConvertAccessTokenError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 => FromJson<AuthError>(response, ct).As(AsAuthError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ConvertAccessTokenErrorResponse : IErrorResponse<ConvertAccessTokenError>
{
    public static ConvertAccessTokenErrorResponse Instance { get; } = new();

    private ConvertAccessTokenErrorResponse()
    {
    }

    public Task<ConvertAccessTokenError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ConvertAccessTokenError.Create(response, ct);
}

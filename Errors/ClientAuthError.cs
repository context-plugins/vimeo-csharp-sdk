using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class ClientAuthError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private ClientAuthError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static ClientAuthError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static ClientAuthError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<ClientAuthError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class ClientAuthErrorResponse : IErrorResponse<ClientAuthError>
{
    public static ClientAuthErrorResponse Instance { get; } = new();

    private ClientAuthErrorResponse()
    {
    }

    public Task<ClientAuthError> Map(HttpResponseMessage response, CancellationToken ct) =>
        ClientAuthError.Create(response, ct);
}

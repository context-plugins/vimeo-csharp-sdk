using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteAnimatedThumbsetError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteAnimatedThumbsetError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteAnimatedThumbsetError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteAnimatedThumbsetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteAnimatedThumbsetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteAnimatedThumbsetErrorResponse : IErrorResponse<DeleteAnimatedThumbsetError>
{
    public static DeleteAnimatedThumbsetErrorResponse Instance { get; } = new();

    private DeleteAnimatedThumbsetErrorResponse()
    {
    }

    public Task<DeleteAnimatedThumbsetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteAnimatedThumbsetError.Create(response, ct);
}

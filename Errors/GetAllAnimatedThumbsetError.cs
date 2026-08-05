using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAllAnimatedThumbsetError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAllAnimatedThumbsetError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAllAnimatedThumbsetError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAllAnimatedThumbsetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAllAnimatedThumbsetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAllAnimatedThumbsetErrorResponse : IErrorResponse<GetAllAnimatedThumbsetError>
{
    public static GetAllAnimatedThumbsetErrorResponse Instance { get; } = new();

    private GetAllAnimatedThumbsetErrorResponse()
    {
    }

    public Task<GetAllAnimatedThumbsetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAllAnimatedThumbsetError.Create(response, ct);
}

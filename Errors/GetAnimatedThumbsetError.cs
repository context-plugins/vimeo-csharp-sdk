using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetAnimatedThumbsetError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAnimatedThumbsetError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAnimatedThumbsetError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAnimatedThumbsetError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAnimatedThumbsetError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAnimatedThumbsetErrorResponse : IErrorResponse<GetAnimatedThumbsetError>
{
    public static GetAnimatedThumbsetErrorResponse Instance { get; } = new();

    private GetAnimatedThumbsetErrorResponse()
    {
    }

    public Task<GetAnimatedThumbsetError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAnimatedThumbsetError.Create(response, ct);
}

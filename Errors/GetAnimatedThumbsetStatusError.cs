using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetAnimatedThumbsetStatusError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAnimatedThumbsetStatusError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAnimatedThumbsetStatusError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAnimatedThumbsetStatusError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAnimatedThumbsetStatusError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAnimatedThumbsetStatusErrorResponse : IErrorResponse<GetAnimatedThumbsetStatusError>
{
    public static GetAnimatedThumbsetStatusErrorResponse Instance { get; } = new();

    private GetAnimatedThumbsetStatusErrorResponse()
    {
    }

    public Task<GetAnimatedThumbsetStatusError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAnimatedThumbsetStatusError.Create(response, ct);
}

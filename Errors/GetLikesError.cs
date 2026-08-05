using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetLikesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLikesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLikesError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetLikesError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLikesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLikesErrorResponse : IErrorResponse<GetLikesError>
{
    public static GetLikesErrorResponse Instance { get; } = new();

    private GetLikesErrorResponse()
    {
    }

    public Task<GetLikesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLikesError.Create(response, ct);
}

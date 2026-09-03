using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetGenreVodsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetGenreVodsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetGenreVodsError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetGenreVodsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetGenreVodsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetGenreVodsErrorResponse : IErrorResponse<GetGenreVodsError>
{
    public static GetGenreVodsErrorResponse Instance { get; } = new();

    private GetGenreVodsErrorResponse()
    {
    }

    public Task<GetGenreVodsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetGenreVodsError.Create(response, ct);
}

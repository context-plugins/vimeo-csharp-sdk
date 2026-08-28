using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteVideosError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteVideosError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteVideosError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static DeleteVideosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteVideosError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideosErrorResponse : IErrorResponse<DeleteVideosError>
{
    public static DeleteVideosErrorResponse Instance { get; } = new();

    private DeleteVideosErrorResponse()
    {
    }

    public Task<DeleteVideosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideosError.Create(response, ct);
}

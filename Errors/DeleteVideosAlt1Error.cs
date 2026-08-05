using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteVideosAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteVideosAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteVideosAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static DeleteVideosAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteVideosAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteVideosAlt1ErrorResponse : IErrorResponse<DeleteVideosAlt1Error>
{
    public static DeleteVideosAlt1ErrorResponse Instance { get; } = new();

    private DeleteVideosAlt1ErrorResponse()
    {
    }

    public Task<DeleteVideosAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteVideosAlt1Error.Create(response, ct);
}

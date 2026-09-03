using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteOttDestinationError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteOttDestinationError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteOttDestinationError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteOttDestinationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteOttDestinationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteOttDestinationErrorResponse : IErrorResponse<DeleteOttDestinationError>
{
    public static DeleteOttDestinationErrorResponse Instance { get; } = new();

    private DeleteOttDestinationErrorResponse()
    {
    }

    public Task<DeleteOttDestinationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteOttDestinationError.Create(response, ct);
}

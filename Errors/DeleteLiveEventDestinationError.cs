using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteLiveEventDestinationError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventDestinationError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventDestinationError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventDestinationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventDestinationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventDestinationErrorResponse : IErrorResponse<DeleteLiveEventDestinationError>
{
    public static DeleteLiveEventDestinationErrorResponse Instance { get; } = new();

    private DeleteLiveEventDestinationErrorResponse()
    {
    }

    public Task<DeleteLiveEventDestinationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventDestinationError.Create(response, ct);
}

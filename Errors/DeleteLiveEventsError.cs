using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteLiveEventsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventsError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventsErrorResponse : IErrorResponse<DeleteLiveEventsError>
{
    public static DeleteLiveEventsErrorResponse Instance { get; } = new();

    private DeleteLiveEventsErrorResponse()
    {
    }

    public Task<DeleteLiveEventsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventsError.Create(response, ct);
}

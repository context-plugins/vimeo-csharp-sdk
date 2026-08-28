using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteLiveEventsAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventsAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventsAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventsAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventsAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventsAlt2ErrorResponse : IErrorResponse<DeleteLiveEventsAlt2Error>
{
    public static DeleteLiveEventsAlt2ErrorResponse Instance { get; } = new();

    private DeleteLiveEventsAlt2ErrorResponse()
    {
    }

    public Task<DeleteLiveEventsAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventsAlt2Error.Create(response, ct);
}

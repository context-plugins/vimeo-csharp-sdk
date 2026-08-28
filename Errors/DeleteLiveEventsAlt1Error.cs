using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class DeleteLiveEventsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventsAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventsAlt1ErrorResponse : IErrorResponse<DeleteLiveEventsAlt1Error>
{
    public static DeleteLiveEventsAlt1ErrorResponse Instance { get; } = new();

    private DeleteLiveEventsAlt1ErrorResponse()
    {
    }

    public Task<DeleteLiveEventsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventsAlt1Error.Create(response, ct);
}

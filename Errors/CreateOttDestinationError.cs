using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class CreateOttDestinationError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private CreateOttDestinationError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static CreateOttDestinationError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static CreateOttDestinationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<CreateOttDestinationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateOttDestinationErrorResponse : IErrorResponse<CreateOttDestinationError>
{
    public static CreateOttDestinationErrorResponse Instance { get; } = new();

    private CreateOttDestinationErrorResponse()
    {
    }

    public Task<CreateOttDestinationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateOttDestinationError.Create(response, ct);
}

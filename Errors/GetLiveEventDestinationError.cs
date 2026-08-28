using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventDestinationError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventDestinationError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventDestinationError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventDestinationError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventDestinationError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventDestinationErrorResponse : IErrorResponse<GetLiveEventDestinationError>
{
    public static GetLiveEventDestinationErrorResponse Instance { get; } = new();

    private GetLiveEventDestinationErrorResponse()
    {
    }

    public Task<GetLiveEventDestinationError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventDestinationError.Create(response, ct);
}

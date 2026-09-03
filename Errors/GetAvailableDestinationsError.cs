using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAvailableDestinationsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAvailableDestinationsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAvailableDestinationsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAvailableDestinationsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAvailableDestinationsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAvailableDestinationsErrorResponse : IErrorResponse<GetAvailableDestinationsError>
{
    public static GetAvailableDestinationsErrorResponse Instance { get; } = new();

    private GetAvailableDestinationsErrorResponse()
    {
    }

    public Task<GetAvailableDestinationsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAvailableDestinationsError.Create(response, ct);
}

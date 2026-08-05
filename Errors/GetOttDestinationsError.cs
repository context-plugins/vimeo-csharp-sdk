using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetOttDestinationsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetOttDestinationsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetOttDestinationsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetOttDestinationsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetOttDestinationsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetOttDestinationsErrorResponse : IErrorResponse<GetOttDestinationsError>
{
    public static GetOttDestinationsErrorResponse Instance { get; } = new();

    private GetOttDestinationsErrorResponse()
    {
    }

    public Task<GetOttDestinationsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetOttDestinationsError.Create(response, ct);
}

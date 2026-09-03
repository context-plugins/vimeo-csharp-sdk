using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAvailableDestinationsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAvailableDestinationsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAvailableDestinationsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAvailableDestinationsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAvailableDestinationsAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAvailableDestinationsAlt1ErrorResponse : IErrorResponse<GetAvailableDestinationsAlt1Error>
{
    public static GetAvailableDestinationsAlt1ErrorResponse Instance { get; } = new();

    private GetAvailableDestinationsAlt1ErrorResponse()
    {
    }

    public Task<GetAvailableDestinationsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAvailableDestinationsAlt1Error.Create(response, ct);
}

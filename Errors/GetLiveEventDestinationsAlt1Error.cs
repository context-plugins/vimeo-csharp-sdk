using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetLiveEventDestinationsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventDestinationsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventDestinationsAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventDestinationsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventDestinationsAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventDestinationsAlt1ErrorResponse : IErrorResponse<GetLiveEventDestinationsAlt1Error>
{
    public static GetLiveEventDestinationsAlt1ErrorResponse Instance { get; } = new();

    private GetLiveEventDestinationsAlt1ErrorResponse()
    {
    }

    public Task<GetLiveEventDestinationsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventDestinationsAlt1Error.Create(response, ct);
}

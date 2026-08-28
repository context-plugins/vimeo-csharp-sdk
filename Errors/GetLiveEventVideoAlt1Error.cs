using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventVideoAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventVideoAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventVideoAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventVideoAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventVideoAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventVideoAlt1ErrorResponse : IErrorResponse<GetLiveEventVideoAlt1Error>
{
    public static GetLiveEventVideoAlt1ErrorResponse Instance { get; } = new();

    private GetLiveEventVideoAlt1ErrorResponse()
    {
    }

    public Task<GetLiveEventVideoAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventVideoAlt1Error.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventVideosAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventVideosAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventVideosAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetLiveEventVideosAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventVideosAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventVideosAlt1ErrorResponse : IErrorResponse<GetLiveEventVideosAlt1Error>
{
    public static GetLiveEventVideosAlt1ErrorResponse Instance { get; } = new();

    private GetLiveEventVideosAlt1ErrorResponse()
    {
    }

    public Task<GetLiveEventVideosAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventVideosAlt1Error.Create(response, ct);
}

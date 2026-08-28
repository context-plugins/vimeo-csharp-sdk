using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetOneTimeEventM3U8PlaybackAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetOneTimeEventM3U8PlaybackAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetOneTimeEventM3U8PlaybackAlt1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetOneTimeEventM3U8PlaybackAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetOneTimeEventM3U8PlaybackAlt1Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetOneTimeEventM3U8PlaybackAlt1ErrorResponse : IErrorResponse<GetOneTimeEventM3U8PlaybackAlt1Error>
{
    public static GetOneTimeEventM3U8PlaybackAlt1ErrorResponse Instance { get; } = new();

    private GetOneTimeEventM3U8PlaybackAlt1ErrorResponse()
    {
    }

    public Task<GetOneTimeEventM3U8PlaybackAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetOneTimeEventM3U8PlaybackAlt1Error.Create(response, ct);
}

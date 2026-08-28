using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetOneTimeEventM3U8PlaybackError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetOneTimeEventM3U8PlaybackError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetOneTimeEventM3U8PlaybackError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetOneTimeEventM3U8PlaybackError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetOneTimeEventM3U8PlaybackError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetOneTimeEventM3U8PlaybackErrorResponse : IErrorResponse<GetOneTimeEventM3U8PlaybackError>
{
    public static GetOneTimeEventM3U8PlaybackErrorResponse Instance { get; } = new();

    private GetOneTimeEventM3U8PlaybackErrorResponse()
    {
    }

    public Task<GetOneTimeEventM3U8PlaybackError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetOneTimeEventM3U8PlaybackError.Create(response, ct);
}

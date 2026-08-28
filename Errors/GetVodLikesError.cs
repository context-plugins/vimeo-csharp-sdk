using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVodLikesError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetVodLikesError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetVodLikesError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetVodLikesError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetVodLikesError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodLikesErrorResponse : IErrorResponse<GetVodLikesError>
{
    public static GetVodLikesErrorResponse Instance { get; } = new();

    private GetVodLikesErrorResponse()
    {
    }

    public Task<GetVodLikesError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodLikesError.Create(response, ct);
}

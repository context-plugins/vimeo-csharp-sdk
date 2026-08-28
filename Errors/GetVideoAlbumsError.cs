using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVideoAlbumsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetVideoAlbumsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetVideoAlbumsError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetVideoAlbumsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetVideoAlbumsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVideoAlbumsErrorResponse : IErrorResponse<GetVideoAlbumsError>
{
    public static GetVideoAlbumsErrorResponse Instance { get; } = new();

    private GetVideoAlbumsErrorResponse()
    {
    }

    public Task<GetVideoAlbumsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVideoAlbumsError.Create(response, ct);
}

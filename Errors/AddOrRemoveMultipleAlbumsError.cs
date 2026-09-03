using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class AddOrRemoveMultipleAlbumsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private AddOrRemoveMultipleAlbumsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static AddOrRemoveMultipleAlbumsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static AddOrRemoveMultipleAlbumsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<AddOrRemoveMultipleAlbumsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class AddOrRemoveMultipleAlbumsErrorResponse : IErrorResponse<AddOrRemoveMultipleAlbumsError>
{
    public static AddOrRemoveMultipleAlbumsErrorResponse Instance { get; } = new();

    private AddOrRemoveMultipleAlbumsErrorResponse()
    {
    }

    public Task<AddOrRemoveMultipleAlbumsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        AddOrRemoveMultipleAlbumsError.Create(response, ct);
}

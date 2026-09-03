using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteLiveEventError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventErrorResponse : IErrorResponse<DeleteLiveEventError>
{
    public static DeleteLiveEventErrorResponse Instance { get; } = new();

    private DeleteLiveEventErrorResponse()
    {
    }

    public Task<DeleteLiveEventError> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventError.Create(response, ct);
}

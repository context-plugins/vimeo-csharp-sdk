using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class DeleteLiveEventAlt2Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private DeleteLiveEventAlt2Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static DeleteLiveEventAlt2Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static DeleteLiveEventAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<DeleteLiveEventAlt2Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class DeleteLiveEventAlt2ErrorResponse : IErrorResponse<DeleteLiveEventAlt2Error>
{
    public static DeleteLiveEventAlt2ErrorResponse Instance { get; } = new();

    private DeleteLiveEventAlt2ErrorResponse()
    {
    }

    public Task<DeleteLiveEventAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        DeleteLiveEventAlt2Error.Create(response, ct);
}

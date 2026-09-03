using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class RemoveVideosFromProjectError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RemoveVideosFromProjectError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RemoveVideosFromProjectError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RemoveVideosFromProjectError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RemoveVideosFromProjectError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveVideosFromProjectErrorResponse : IErrorResponse<RemoveVideosFromProjectError>
{
    public static RemoveVideosFromProjectErrorResponse Instance { get; } = new();

    private RemoveVideosFromProjectErrorResponse()
    {
    }

    public Task<RemoveVideosFromProjectError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveVideosFromProjectError.Create(response, ct);
}

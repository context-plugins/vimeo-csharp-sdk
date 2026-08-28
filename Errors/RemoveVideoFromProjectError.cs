using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class RemoveVideoFromProjectError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private RemoveVideoFromProjectError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static RemoveVideoFromProjectError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static RemoveVideoFromProjectError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<RemoveVideoFromProjectError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveVideoFromProjectErrorResponse : IErrorResponse<RemoveVideoFromProjectError>
{
    public static RemoveVideoFromProjectErrorResponse Instance { get; } = new();

    private RemoveVideoFromProjectErrorResponse()
    {
    }

    public Task<RemoveVideoFromProjectError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveVideoFromProjectError.Create(response, ct);
}

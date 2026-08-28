using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetLiveEventVideoError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetLiveEventVideoError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetLiveEventVideoError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetLiveEventVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetLiveEventVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetLiveEventVideoErrorResponse : IErrorResponse<GetLiveEventVideoError>
{
    public static GetLiveEventVideoErrorResponse Instance { get; } = new();

    private GetLiveEventVideoErrorResponse()
    {
    }

    public Task<GetLiveEventVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetLiveEventVideoError.Create(response, ct);
}

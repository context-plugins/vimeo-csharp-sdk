using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetProjectVideosError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetProjectVideosError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetProjectVideosError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetProjectVideosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetProjectVideosError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetProjectVideosErrorResponse : IErrorResponse<GetProjectVideosError>
{
    public static GetProjectVideosErrorResponse Instance { get; } = new();

    private GetProjectVideosErrorResponse()
    {
    }

    public Task<GetProjectVideosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetProjectVideosError.Create(response, ct);
}

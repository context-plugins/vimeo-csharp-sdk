using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetAvailableVideoGroupsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetAvailableVideoGroupsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetAvailableVideoGroupsError AsError(Error value) =>
        new(Optional<Error>.Some(value), default);

    private static GetAvailableVideoGroupsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetAvailableVideoGroupsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetAvailableVideoGroupsErrorResponse : IErrorResponse<GetAvailableVideoGroupsError>
{
    public static GetAvailableVideoGroupsErrorResponse Instance { get; } = new();

    private GetAvailableVideoGroupsErrorResponse()
    {
    }

    public Task<GetAvailableVideoGroupsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetAvailableVideoGroupsError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetUserGroupsError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetUserGroupsError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetUserGroupsError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetUserGroupsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetUserGroupsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetUserGroupsErrorResponse : IErrorResponse<GetUserGroupsError>
{
    public static GetUserGroupsErrorResponse Instance { get; } = new();

    private GetUserGroupsErrorResponse()
    {
    }

    public Task<GetUserGroupsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetUserGroupsError.Create(response, ct);
}

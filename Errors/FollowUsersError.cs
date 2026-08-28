using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class FollowUsersError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FollowUsersError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FollowUsersError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static FollowUsersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FollowUsersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 429 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FollowUsersErrorResponse : IErrorResponse<FollowUsersError>
{
    public static FollowUsersErrorResponse Instance { get; } = new();

    private FollowUsersErrorResponse()
    {
    }

    public Task<FollowUsersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        FollowUsersError.Create(response, ct);
}

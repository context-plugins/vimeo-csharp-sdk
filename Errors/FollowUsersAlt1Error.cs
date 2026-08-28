using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class FollowUsersAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private FollowUsersAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static FollowUsersAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static FollowUsersAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<FollowUsersAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 429 or 500 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class FollowUsersAlt1ErrorResponse : IErrorResponse<FollowUsersAlt1Error>
{
    public static FollowUsersAlt1ErrorResponse Instance { get; } = new();

    private FollowUsersAlt1ErrorResponse()
    {
    }

    public Task<FollowUsersAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        FollowUsersAlt1Error.Create(response, ct);
}

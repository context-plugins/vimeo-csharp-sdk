using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetUserGroupsAlt1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private GetUserGroupsAlt1Error(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static GetUserGroupsAlt1Error AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static GetUserGroupsAlt1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    internal static Task<GetUserGroupsAlt1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<Error>(response, ct).As(AsError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetUserGroupsAlt1ErrorResponse : IErrorResponse<GetUserGroupsAlt1Error>
{
    public static GetUserGroupsAlt1ErrorResponse Instance { get; } = new();

    private GetUserGroupsAlt1ErrorResponse()
    {
    }

    public Task<GetUserGroupsAlt1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetUserGroupsAlt1Error.Create(response, ct);
}

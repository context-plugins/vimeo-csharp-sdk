using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetGroupMembersError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetGroupMembersError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetGroupMembersError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetGroupMembersError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetGroupMembersError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetGroupMembersErrorResponse : IErrorResponse<GetGroupMembersError>
{
    public static GetGroupMembersErrorResponse Instance { get; } = new();

    private GetGroupMembersErrorResponse()
    {
    }

    public Task<GetGroupMembersError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetGroupMembersError.Create(response, ct);
}

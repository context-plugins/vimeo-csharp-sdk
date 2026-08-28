using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetCategoryGroupsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCategoryGroupsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCategoryGroupsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCategoryGroupsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCategoryGroupsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCategoryGroupsErrorResponse : IErrorResponse<GetCategoryGroupsError>
{
    public static GetCategoryGroupsErrorResponse Instance { get; } = new();

    private GetCategoryGroupsErrorResponse()
    {
    }

    public Task<GetCategoryGroupsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCategoryGroupsError.Create(response, ct);
}

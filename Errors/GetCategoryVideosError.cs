using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetCategoryVideosError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetCategoryVideosError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetCategoryVideosError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetCategoryVideosError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetCategoryVideosError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCategoryVideosErrorResponse : IErrorResponse<GetCategoryVideosError>
{
    public static GetCategoryVideosErrorResponse Instance { get; } = new();

    private GetCategoryVideosErrorResponse()
    {
    }

    public Task<GetCategoryVideosError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCategoryVideosError.Create(response, ct);
}

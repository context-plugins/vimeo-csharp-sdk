using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVodSeasonError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodSeasonError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodSeasonError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodSeasonError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodSeasonError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodSeasonErrorResponse : IErrorResponse<GetVodSeasonError>
{
    public static GetVodSeasonErrorResponse Instance { get; } = new();

    private GetVodSeasonErrorResponse()
    {
    }

    public Task<GetVodSeasonError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodSeasonError.Create(response, ct);
}

using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetVodBackgroundsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetVodBackgroundsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetVodBackgroundsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetVodBackgroundsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetVodBackgroundsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetVodBackgroundsErrorResponse : IErrorResponse<GetVodBackgroundsError>
{
    public static GetVodBackgroundsErrorResponse Instance { get; } = new();

    private GetVodBackgroundsErrorResponse()
    {
    }

    public Task<GetVodBackgroundsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetVodBackgroundsError.Create(response, ct);
}

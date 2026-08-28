using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Vimeo.Core.ErrorResponse;
using Vimeo.Core.Models;
using Vimeo.Models;

namespace Vimeo.Errors;

public sealed class GetChannelVideoError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetChannelVideoError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetChannelVideoError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetChannelVideoError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetChannelVideoError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChannelVideoErrorResponse : IErrorResponse<GetChannelVideoError>
{
    public static GetChannelVideoErrorResponse Instance { get; } = new();

    private GetChannelVideoErrorResponse()
    {
    }

    public Task<GetChannelVideoError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChannelVideoError.Create(response, ct);
}

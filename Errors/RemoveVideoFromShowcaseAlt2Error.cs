using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class RemoveVideoFromShowcaseAlt2Error : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private RemoveVideoFromShowcaseAlt2Error(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static RemoveVideoFromShowcaseAlt2Error AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static RemoveVideoFromShowcaseAlt2Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<RemoveVideoFromShowcaseAlt2Error> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveVideoFromShowcaseAlt2ErrorResponse : IErrorResponse<RemoveVideoFromShowcaseAlt2Error>
{
    public static RemoveVideoFromShowcaseAlt2ErrorResponse Instance { get; } = new();

    private RemoveVideoFromShowcaseAlt2ErrorResponse()
    {
    }

    public Task<RemoveVideoFromShowcaseAlt2Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveVideoFromShowcaseAlt2Error.Create(response, ct);
}

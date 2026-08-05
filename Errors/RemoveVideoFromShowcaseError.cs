using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class RemoveVideoFromShowcaseError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private RemoveVideoFromShowcaseError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static RemoveVideoFromShowcaseError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static RemoveVideoFromShowcaseError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<RemoveVideoFromShowcaseError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class RemoveVideoFromShowcaseErrorResponse : IErrorResponse<RemoveVideoFromShowcaseError>
{
    public static RemoveVideoFromShowcaseErrorResponse Instance { get; } = new();

    private RemoveVideoFromShowcaseErrorResponse()
    {
    }

    public Task<RemoveVideoFromShowcaseError> Map(HttpResponseMessage response, CancellationToken ct) =>
        RemoveVideoFromShowcaseError.Create(response, ct);
}

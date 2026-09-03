using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetShowcaseCustomThumbnailError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetShowcaseCustomThumbnailError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetShowcaseCustomThumbnailError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetShowcaseCustomThumbnailError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetShowcaseCustomThumbnailError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 or 404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetShowcaseCustomThumbnailErrorResponse : IErrorResponse<GetShowcaseCustomThumbnailError>
{
    public static GetShowcaseCustomThumbnailErrorResponse Instance { get; } = new();

    private GetShowcaseCustomThumbnailErrorResponse()
    {
    }

    public Task<GetShowcaseCustomThumbnailError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetShowcaseCustomThumbnailError.Create(response, ct);
}

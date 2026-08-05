using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class SetChapterThumbnailActiveError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private SetChapterThumbnailActiveError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static SetChapterThumbnailActiveError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static SetChapterThumbnailActiveError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<SetChapterThumbnailActiveError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            404 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SetChapterThumbnailActiveErrorResponse : IErrorResponse<SetChapterThumbnailActiveError>
{
    public static SetChapterThumbnailActiveErrorResponse Instance { get; } = new();

    private SetChapterThumbnailActiveErrorResponse()
    {
    }

    public Task<SetChapterThumbnailActiveError> Map(HttpResponseMessage response, CancellationToken ct) =>
        SetChapterThumbnailActiveError.Create(response, ct);
}

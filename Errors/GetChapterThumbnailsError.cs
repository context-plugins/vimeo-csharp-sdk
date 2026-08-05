using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class GetChapterThumbnailsError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private GetChapterThumbnailsError(Optional<LegacyError> legacyErrorValue, Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static GetChapterThumbnailsError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static GetChapterThumbnailsError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<GetChapterThumbnailsError> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetChapterThumbnailsErrorResponse : IErrorResponse<GetChapterThumbnailsError>
{
    public static GetChapterThumbnailsErrorResponse Instance { get; } = new();

    private GetChapterThumbnailsErrorResponse()
    {
    }

    public Task<GetChapterThumbnailsError> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetChapterThumbnailsError.Create(response, ct);
}

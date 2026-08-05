using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateChapterThumbnailOrUploadLinkError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateChapterThumbnailOrUploadLinkError(Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateChapterThumbnailOrUploadLinkError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateChapterThumbnailOrUploadLinkError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateChapterThumbnailOrUploadLinkError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateChapterThumbnailOrUploadLinkErrorResponse : IErrorResponse<CreateChapterThumbnailOrUploadLinkError>
{
    public static CreateChapterThumbnailOrUploadLinkErrorResponse Instance { get; } = new();

    private CreateChapterThumbnailOrUploadLinkErrorResponse()
    {
    }

    public Task<CreateChapterThumbnailOrUploadLinkError> Map(HttpResponseMessage response, CancellationToken ct) =>
        CreateChapterThumbnailOrUploadLinkError.Create(response, ct);
}

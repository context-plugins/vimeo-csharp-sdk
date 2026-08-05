using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using VimeoApi.Core.ErrorResponse;
using VimeoApi.Core.Models;
using VimeoApi.Models;

namespace VimeoApi.Errors;

public sealed class CreateUnsavedChapterThumbnailOrUploadLinkError : ApiError
{
    private readonly Optional<LegacyError> _legacyErrorValue;

    private CreateUnsavedChapterThumbnailOrUploadLinkError(Optional<LegacyError> legacyErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _legacyErrorValue = legacyErrorValue;
    }

    private static CreateUnsavedChapterThumbnailOrUploadLinkError AsLegacyError(LegacyError value) =>
        new(Optional<LegacyError>.Some(value), default);

    private static CreateUnsavedChapterThumbnailOrUploadLinkError AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetLegacyError(out LegacyError value) => _legacyErrorValue.TryGetValue(out value);

    internal static Task<CreateUnsavedChapterThumbnailOrUploadLinkError> Create(HttpResponseMessage response,
        CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            403 => FromJson<LegacyError>(response, ct).As(AsLegacyError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CreateUnsavedChapterThumbnailOrUploadLinkErrorResponse : IErrorResponse<CreateUnsavedChapterThumbnailOrUploadLinkError>
{
    public static CreateUnsavedChapterThumbnailOrUploadLinkErrorResponse Instance { get; } = new();

    private CreateUnsavedChapterThumbnailOrUploadLinkErrorResponse()
    {
    }

    public Task<CreateUnsavedChapterThumbnailOrUploadLinkError> Map(HttpResponseMessage response,
        CancellationToken ct) => CreateUnsavedChapterThumbnailOrUploadLinkError.Create(response, ct);
}

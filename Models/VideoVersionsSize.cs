using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record VideoVersionsSize
{
    /// <summary>
    /// The status of the video and its corresponding file size type.
    /// <para>
    /// Option descriptions:
    ///  * <c>PROCESSING</c> - The video is still processing or transcoding, and its file size isn't available yet.
    ///  * <c>QUOTA_EXEMPT_CLIP</c> - The video is exempt from the user's storage quota.
    ///  * <c>QUOTA_EXEMPT_USER</c> - The user is on an unlimited plan, and the video doesn't count against their storage quota.
    ///  * <c>STOCK</c> - The video is stock footage. Stock videos don't count against the user's storage quota.
    ///  * <c>UPLOAD</c> - The video is a regular upload, and its file size counts against the user's storage quota.
    ///  * <c>UPLOAD_FAILURE</c> - The video failed to upload, and its file size doesn't count against the user's storage quota.
    ///  * <c>VIMEO_CREATE</c> - The video was created using the Vimeo Create app. Vimeo Create videos don't count against the user's storage quota.
    ///  * <c>VIMEO_RECORD</c> - The video was recorded using the Vimeo Record app. Videos for some Vimeo Record API apps don't count against the user's storage quota.
    /// </para>
    /// </summary>
    [JsonPropertyName("file_size_type")]
    public required FileSizeType FileSizeType { get; init; }

    /// <summary>
    /// The number of versions for the video.
    /// </summary>
    [JsonPropertyName("num_versions")]
    public required double NumVersions { get; init; }

    /// <summary>
    /// The total combined file size for all versions of the video.
    /// </summary>
    [JsonPropertyName("total_size")]
    public required double TotalSize { get; init; }
}

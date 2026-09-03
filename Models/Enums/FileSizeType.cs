using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<FileSizeType>))]
public sealed record FileSizeType : StringEnum<FileSizeType>
{
    private FileSizeType(string value) : base(value)
    {
    }

    public static readonly FileSizeType Processing = new("PROCESSING");

    public static readonly FileSizeType QuotaExemptClip = new("QUOTA_EXEMPT_CLIP");

    public static readonly FileSizeType QuotaExemptUser = new("QUOTA_EXEMPT_USER");

    public static readonly FileSizeType Stock = new("STOCK");

    public static readonly FileSizeType Upload = new("UPLOAD");

    public static readonly FileSizeType UploadFailure = new("UPLOAD_FAILURE");

    public static readonly FileSizeType VimeoCreate = new("VIMEO_CREATE");

    public static readonly FileSizeType VimeoRecord = new("VIMEO_RECORD");

    public static FileSizeType FromValue(string value) => FromValueCore(value);
}

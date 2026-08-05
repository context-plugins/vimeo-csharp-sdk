using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The status code for the availability of the video.
/// <para>
/// Option descriptions:
///  * <c>available</c> - The video is available.
///  * <c>failed</c> - There was an error in rendering the video.
///  * <c>processing</c> - Rendering has started and is currently underway for the video.
///  * <c>quota_exceeded</c> - The user's weekly upload quota is exceeded with this video.
///  * <c>total_cap_exceeded</c> - The user's total storage limit is exceeded with this video.
///  * <c>transcode_starting</c> - Transcoding is starting for the video.
///  * <c>transcoding</c> - Transcoding has started and is currently underway for the video.
///  * <c>transcoding_error</c> - There was an error in transcoding the video.
///  * <c>unavailable</c> - The video is unavailable.
///  * <c>uploading</c> - The video is being uploaded.
///  * <c>uploading_error</c> - There was an error in uploading the video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status5>))]
public sealed record Status5 : StringEnum<Status5>
{
    private Status5(string value) : base(value)
    {
    }

    public static readonly Status5 Available = new("available");

    public static readonly Status5 Failed = new("failed");

    public static readonly Status5 Processing = new("processing");

    public static readonly Status5 QuotaExceeded = new("quota_exceeded");

    public static readonly Status5 TotalCapExceeded = new("total_cap_exceeded");

    public static readonly Status5 TranscodeStarting = new("transcode_starting");

    public static readonly Status5 Transcoding = new("transcoding");

    public static readonly Status5 TranscodingError = new("transcoding_error");

    public static readonly Status5 Unavailable = new("unavailable");

    public static readonly Status5 Uploading = new("uploading");

    public static readonly Status5 UploadingError = new("uploading_error");

    public static Status5 FromValue(string value) => FromValueCore(value);
}

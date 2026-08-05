using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The status of the video.
/// <para>
/// Option descriptions:
///  * <c>done</c> - The video is finished processing.
///  * <c>failed</c> - Video processing has failed.
///  * <c>processing</c> - The video is still being processed.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status2>))]
public sealed record Status2 : StringEnum<Status2>
{
    private Status2(string value) : base(value)
    {
    }

    public static readonly Status2 Done = new("done");

    public static readonly Status2 Failed = new("failed");

    public static readonly Status2 Processing = new("processing");

    public static Status2 FromValue(string value) => FromValueCore(value);
}

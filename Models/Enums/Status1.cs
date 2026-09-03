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
[JsonConverter(typeof(StringEnumConverter<Status1>))]
public sealed record Status1 : StringEnum<Status1>
{
    private Status1(string value) : base(value)
    {
    }

    public static readonly Status1 Done = new("done");

    public static readonly Status1 Failed = new("failed");

    public static readonly Status1 Processing = new("processing");

    public static Status1 FromValue(string value) => FromValueCore(value);
}

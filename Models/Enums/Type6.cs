using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of video file.
/// <para>
/// Option descriptions:
///  * <c>source</c> - The video file is a source file.
///  * <c>video/mp4</c> - The video file is in MP4 format.
///  * <c>video/webm</c> - The video file is in WebM format.
///  * <c>vp6/x-video</c> - The video file is in VP6 format.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type6>))]
public sealed record Type6 : StringEnum<Type6>
{
    private Type6(string value) : base(value)
    {
    }

    public static readonly Type6 Source = new("source");

    public static readonly Type6 VideoMp4 = new("video/mp4");

    public static readonly Type6 VideoWebm = new("video/webm");

    public static readonly Type6 Vp6XVideo = new("vp6/x-video");

    public static Type6 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of video file.
/// <para>
/// Option descriptions:
///  * <c>audio/mp4</c> - The file is an audio-only MPEG-4 container.
///  * <c>source</c> - The video file is a source file.
///  * <c>video/mp4</c> - The video file is in MP4 format.
///  * <c>video/webm</c> - The video file is in WebM format.
///  * <c>vp6/x-video</c> - The video file is in VP6 format.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type3>))]
public sealed record Type3 : StringEnum<Type3>
{
    private Type3(string value) : base(value)
    {
    }

    public static readonly Type3 AudioMp4 = new("audio/mp4");

    public static readonly Type3 Source = new("source");

    public static readonly Type3 VideoMp4 = new("video/mp4");

    public static readonly Type3 VideoWebm = new("video/webm");

    public static readonly Type3 Vp6XVideo = new("vp6/x-video");

    public static Type3 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The protocol used for this session.
/// <para>
/// Option descriptions:
///  * <c>dash</c> - The protocol is DASH.
///  * <c>rtmp</c> - The protocol is RTMP.
///  * <c>simple_live</c> - The protocol is Simplelive.
///  * <c>srt</c> - The protocol is SRT.
///  * <c>studio_cloud</c> - The protocol is StudioCloud.
///  * <c>unknown</c> - The protocol is unknown or not set.
///  * <c>webrtc</c> - The protocol is WebRTC.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<EncoderType>))]
public sealed record EncoderType : StringEnum<EncoderType>
{
    private EncoderType(string value) : base(value)
    {
    }

    public static readonly EncoderType Dash = new("dash");

    public static readonly EncoderType Rtmp = new("rtmp");

    public static readonly EncoderType SimpleLive = new("simple_live");

    public static readonly EncoderType Srt = new("srt");

    public static readonly EncoderType StudioCloud = new("studio_cloud");

    public static readonly EncoderType Unknown = new("unknown");

    public static readonly EncoderType Webrtc = new("webrtc");

    public static EncoderType FromValue(string value) => FromValueCore(value);
}

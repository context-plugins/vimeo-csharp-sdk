using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The 360 spatial stereo format.
/// <para>
/// Option descriptions:
///  * <c>left-right</c> - Use left-right stereo.
///  * <c>mono</c> - Use monaural audio.
///  * <c>top-bottom</c> - Use top-bottom stereo.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StereoFormat1>))]
public sealed record StereoFormat1 : StringEnum<StereoFormat1>
{
    private StereoFormat1(string value) : base(value)
    {
    }

    public static readonly StereoFormat1 LeftRight = new("left-right");

    public static readonly StereoFormat1 Mono = new("mono");

    public static readonly StereoFormat1 TopBottom = new("top-bottom");

    public static StereoFormat1 FromValue(string value) => FromValueCore(value);
}

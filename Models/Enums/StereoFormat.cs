using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The video's 360 stereo format.
/// <para>
/// Option descriptions:
///  * <c>left-right</c> - The stereo format is left-right.
///  * <c>mono</c> - The audio is monaural.
///  * <c>top-bottom</c> - The stereo format is top-bottom.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StereoFormat>))]
public sealed record StereoFormat : StringEnum<StereoFormat>
{
    private StereoFormat(string value) : base(value)
    {
    }

    public static readonly StereoFormat LeftRight = new("left-right");

    public static readonly StereoFormat Mono = new("mono");

    public static readonly StereoFormat TopBottom = new("top-bottom");

    public static StereoFormat FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The video quality as determined by height and width.
/// <para>
/// Option descriptions:
///  * <c>audio</c> - The file is audio-only.
///  * <c>hd</c> - The video is in high definition.
///  * <c>hls</c> - The video is suitable for HTTP live streaming.
///  * <c>mobile</c> - The video is mobile quality.
///  * <c>sd</c> - The video is in standard definition.
///  * <c>source</c> - The video's source file.
///  * <c>uhd</c> - The video resolution is 2K or higher.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Quality>))]
public sealed record Quality : StringEnum<Quality>
{
    private Quality(string value) : base(value)
    {
    }

    public static readonly Quality Audio = new("audio");

    public static readonly Quality Hd = new("hd");

    public static readonly Quality Hls = new("hls");

    public static readonly Quality Mobile = new("mobile");

    public static readonly Quality Sd = new("sd");

    public static readonly Quality Source = new("source");

    public static readonly Quality Uhd = new("uhd");

    public static Quality FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The codec of the video file.
/// <para>
/// Option descriptions:
///  * <c>AV1</c> - The codec is AV1.
///  * <c>H264</c> - The codec is H264.
///  * <c>HEVC</c> - The codec is HEVC.
///  * <c>aac</c> - The audio codec is AAC.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Codec>))]
public sealed record Codec : StringEnum<Codec>
{
    private Codec(string value) : base(value)
    {
    }

    public static readonly Codec Av1 = new("AV1");

    public static readonly Codec H264 = new("H264");

    public static readonly Codec Hevc = new("HEVC");

    public static readonly Codec Aac = new("aac");

    public static Codec FromValue(string value) => FromValueCore(value);
}

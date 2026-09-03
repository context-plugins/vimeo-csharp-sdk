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
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Codec1>))]
public sealed record Codec1 : StringEnum<Codec1>
{
    private Codec1(string value) : base(value)
    {
    }

    public static readonly Codec1 Av1 = new("AV1");

    public static readonly Codec1 H264 = new("H264");

    public static readonly Codec1 Hevc = new("HEVC");

    public static Codec1 FromValue(string value) => FromValueCore(value);
}

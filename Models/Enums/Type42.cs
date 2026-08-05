using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of the video.
/// <para>
/// Option descriptions:
///  * <c>extra</c> - The video type is extra footage.
///  * <c>main</c> - The video type is the main video.
///  * <c>trailer</c> - The video type is a trailer.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type42>))]
public sealed record Type42 : StringEnum<Type42>
{
    private Type42(string value) : base(value)
    {
    }

    public static readonly Type42 Extra = new("extra");

    public static readonly Type42 Main = new("main");

    public static readonly Type42 Trailer = new("trailer");

    public static Type42 FromValue(string value) => FromValueCore(value);
}

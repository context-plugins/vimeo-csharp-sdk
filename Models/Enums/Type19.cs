using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of video.
/// <para>
/// Option descriptions:
///  * <c>extra</c> - The video is an extra feature.
///  * <c>main</c> - The video is a main feature.
///  * <c>trailer</c> - The video is a trailer.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type19>))]
public sealed record Type19 : StringEnum<Type19>
{
    private Type19(string value) : base(value)
    {
    }

    public static readonly Type19 Extra = new("extra");

    public static readonly Type19 Main = new("main");

    public static readonly Type19 Trailer = new("trailer");

    public static Type19 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of audio track.
/// <para>
/// Option descriptions:
///  * <c>commentary</c> - The audio track is the commentary type.
///  * <c>descriptive</c> - The audio track is the descriptive type.
///  * <c>main</c> - The audio track is the main type.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type53>))]
public sealed record Type53 : StringEnum<Type53>
{
    private Type53(string value) : base(value)
    {
    }

    public static readonly Type53 Commentary = new("commentary");

    public static readonly Type53 Descriptive = new("descriptive");

    public static readonly Type53 Main = new("main");

    public static Type53 FromValue(string value) => FromValueCore(value);
}

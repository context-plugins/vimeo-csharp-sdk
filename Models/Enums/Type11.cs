using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of audio track.
/// <para>
/// Option descriptions:
///  * <c>commentary</c> - The audio track is a commentary.
///  * <c>descriptive</c> - The audio track is descriptive for accessibility.
///  * <c>main</c> - The audio track is dubbed audio.
///  * <c>unknown</c> - The audio track category is unknown.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type11>))]
public sealed record Type11 : StringEnum<Type11>
{
    private Type11(string value) : base(value)
    {
    }

    public static readonly Type11 Commentary = new("commentary");

    public static readonly Type11 Descriptive = new("descriptive");

    public static readonly Type11 Main = new("main");

    public static readonly Type11 Unknown = new("unknown");

    public static Type11 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of audio track.
/// <para>
/// Option descriptions:
///  * <c>commentary</c> - The audio track is the commentary type.
///  * <c>descriptive</c> - The audio track is the descriptive type.
///  * <c>main</c> - The audio track is the main type.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type57>))]
public sealed record Type57 : StringEnum<Type57>
{
    private Type57(string value) : base(value)
    {
    }

    public static readonly Type57 Commentary = new("commentary");

    public static readonly Type57 Descriptive = new("descriptive");

    public static readonly Type57 Main = new("main");

    public static Type57 FromValue(string value) => FromValueCore(value);
}

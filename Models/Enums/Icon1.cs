using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// An icon that represents the reason why available showcase presets are disabled. This data requires a bearer token with the <c>private</c> scope.
/// <para>
/// Option descriptions:
///  * <c>clock</c> - The reason is represented by a clock icon.
///  * <c>create</c> - The reason is represented by a create icon.
///  * <c>image</c> - The reason is represented by an image icon.
///  * <c>theme</c> - The reason is represented by a theme icon.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Icon1>))]
public sealed record Icon1 : StringEnum<Icon1>
{
    private Icon1(string value) : base(value)
    {
    }

    public static readonly Icon1 Clock = new("clock");

    public static readonly Icon1 Create = new("create");

    public static readonly Icon1 Image = new("image");

    public static readonly Icon1 Theme = new("theme");

    public static Icon1 FromValue(string value) => FromValueCore(value);
}

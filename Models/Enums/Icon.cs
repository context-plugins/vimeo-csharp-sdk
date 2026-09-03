using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// An icon that represents the reason why showcase presets are disabled. This data requires a bearer token with the <c>private</c> scope.
/// <para>
/// Option descriptions:
///  * <c>clock</c> - The reason is represented by a clock icon.
///  * <c>create</c> - The reason is represented by a create icon.
///  * <c>image</c> - The reason is represented by an image icon.
///  * <c>theme</c> - The reason is represented by a theme icon.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Icon>))]
public sealed record Icon : StringEnum<Icon>
{
    private Icon(string value) : base(value)
    {
    }

    public static readonly Icon Clock = new("clock");

    public static readonly Icon Create = new("create");

    public static readonly Icon Image = new("image");

    public static readonly Icon Theme = new("theme");

    public static Icon FromValue(string value) => FromValueCore(value);
}

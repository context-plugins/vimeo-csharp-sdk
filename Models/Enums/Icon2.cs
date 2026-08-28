using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// An icon that represents the reason why publish-to-social presets are disabled.
/// <para>
/// Option descriptions:
///  * <c>clock</c> - The reason is represented by a clock icon.
///  * <c>create</c> - The reason is represented by a create icon.
///  * <c>image</c> - The reason is represented by an image icon.
///  * <c>theme</c> - The reason is represented by a theme icon.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Icon2>))]
public sealed record Icon2 : StringEnum<Icon2>
{
    private Icon2(string value) : base(value)
    {
    }

    public static readonly Icon2 Clock = new("clock");

    public static readonly Icon2 Create = new("create");

    public static readonly Icon2 Image = new("image");

    public static readonly Icon2 Theme = new("theme");

    public static Icon2 FromValue(string value) => FromValueCore(value);
}

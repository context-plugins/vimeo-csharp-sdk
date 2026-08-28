using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The color theme of the showcase.
/// <para>
/// Option descriptions:
///  * <c>dark</c> - The showcase uses the dark theme.
///  * <c>standard</c> - The showcase uses the standard theme.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Theme>))]
public sealed record Theme : StringEnum<Theme>
{
    private Theme(string value) : base(value)
    {
    }

    public static readonly Theme Dark = new("dark");

    public static readonly Theme Standard = new("standard");

    public static Theme FromValue(string value) => FromValueCore(value);
}

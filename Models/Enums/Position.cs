using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The position of the play button within the embeddable player.
/// <para>
/// Option descriptions:
///  * <c>auto</c> - Use Vimeo's default positioning for the play button.
///  * <c>bottom</c> - The play button is positioned at the bottom of the player, except when in tiny mode.
///  * <c>center</c> - The play button is positioned in the center of the player.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Position>))]
public sealed record Position : StringEnum<Position>
{
    private Position(string value) : base(value)
    {
    }

    public static readonly Position Auto = new("auto");

    public static readonly Position Bottom = new("bottom");

    public static readonly Position Center = new("center");

    public static Position FromValue(string value) => FromValueCore(value);
}

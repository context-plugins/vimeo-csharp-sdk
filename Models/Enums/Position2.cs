using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The position of the play button within the video page player.
/// <para>
/// Option descriptions:
///  * <c>auto</c> - Use Vimeo's default positioning for the play button.
///  * <c>bottom</c> - The play button is positioned at the bottom of the player, except when in tiny mode.
///  * <c>center</c> - The play button is positioned in the center of the player.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Position2>))]
public sealed record Position2 : StringEnum<Position2>
{
    private Position2(string value) : base(value)
    {
    }

    public static readonly Position2 Auto = new("auto");

    public static readonly Position2 Bottom = new("bottom");

    public static readonly Position2 Center = new("center");

    public static Position2 FromValue(string value) => FromValueCore(value);
}

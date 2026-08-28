using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of layout for presenting the showcase.
/// <para>
/// Option descriptions:
///  * <c>grid</c> - The videos appear in a grid.
///  * <c>player</c> - The videos appear in the player.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Layout1>))]
public sealed record Layout1 : StringEnum<Layout1>
{
    private Layout1(string value) : base(value)
    {
    }

    public static readonly Layout1 Grid = new("grid");

    public static readonly Layout1 Player = new("player");

    public static Layout1 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of layout for presenting the showcase.
/// <para>
/// Option descriptions:
///  * <c>grid</c> - The showcase videos appear in a grid.
///  * <c>player</c> - The showcase videos appear in the player.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Layout>))]
public sealed record Layout : StringEnum<Layout>
{
    private Layout(string value) : base(value)
    {
    }

    public static readonly Layout Grid = new("grid");

    public static readonly Layout Player = new("player");

    public static Layout FromValue(string value) => FromValueCore(value);
}

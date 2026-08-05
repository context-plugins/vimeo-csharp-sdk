using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The position of the player's play button.
/// <para>
/// Option descriptions:
///  * <c>0</c> - The play button has the default position.
///  * <c>1</c> - The play button appears at the bottom of the interface.
///  * <c>2</c> - The play button appears in the center of the interface.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PlayButtonPosition>))]
public sealed record PlayButtonPosition : StringEnum<PlayButtonPosition>
{
    private PlayButtonPosition(string value) : base(value)
    {
    }

    public static readonly PlayButtonPosition _0 = new("0");

    public static readonly PlayButtonPosition _1 = new("1");

    public static readonly PlayButtonPosition _2 = new("2");

    public static PlayButtonPosition FromValue(string value) => FromValueCore(value);
}

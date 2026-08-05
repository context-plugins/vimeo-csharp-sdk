using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Colors5
{
    /// <summary>
    /// The fourth player color, which controls the player background color.
    /// </summary>
    [JsonPropertyName("color_four")]
    public required string ColorFour { get; init; }

    /// <summary>
    /// The first player color, which controls the color of the progress bar, buttons, and more.
    /// </summary>
    [JsonPropertyName("color_one")]
    public required string ColorOne { get; init; }

    /// <summary>
    /// The third player color, which controls the color of text and icons.
    /// </summary>
    [JsonPropertyName("color_three")]
    public required string ColorThree { get; init; }

    /// <summary>
    /// The second player color, which controls the player accent color. _This field is identical to <b>color</b>._
    /// </summary>
    [JsonPropertyName("color_two")]
    public required string ColorTwo { get; init; }
}

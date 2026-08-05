using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Colors6
{
    /// <summary>
    /// The hexadecimal color code of the fourth player color, which controls the player background color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color_four")]
    public string? ColorFour { get; init; }

    /// <summary>
    /// The hexadecimal color code of the first player color, which controls the color of the progress bar, buttons, and more.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color_one")]
    public string? ColorOne { get; init; }

    /// <summary>
    /// The hexadecimal color code of the third player color, which controls the color of text and icons.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color_three")]
    public string? ColorThree { get; init; }

    /// <summary>
    /// The hexadecimal color code of the second player color, which controls the player accent color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color_two")]
    public string? ColorTwo { get; init; }
}

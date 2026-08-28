using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A collection of information about the colors in the video page player.
/// </summary>
public record Colors1
{
    /// <summary>
    /// The fourth player color, which controls the player background color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color_four")]
    public string? ColorFour { get; init; }

    /// <summary>
    /// The first player color, which controls the color of the progress bar, buttons, and more.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color_one")]
    public string? ColorOne { get; init; }

    /// <summary>
    /// The third player color, which controls the color of text and icons.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color_three")]
    public string? ColorThree { get; init; }

    /// <summary>
    /// The second player color, which controls the player accent color.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("color_two")]
    public string? ColorTwo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

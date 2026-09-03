using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information about the buttons that appear on the interface of the embeddable player.
/// </summary>
public record Buttons
{
    /// <summary>
    /// Whether the button for embeds appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("embed")]
    public required bool Embed { get; init; }

    /// <summary>
    /// Whether the button for fullscreen mode appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("fullscreen")]
    public required bool Fullscreen { get; init; }

    /// <summary>
    /// Whether the button for HD videos appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("hd")]
    public required bool Hd { get; init; }

    /// <summary>
    /// Whether the button for likes appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("like")]
    public required bool Like { get; init; }

    /// <summary>
    /// Whether the button for reactions appears in the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reaction")]
    public bool? Reaction { get; init; }

    /// <summary>
    /// Whether the button for scaling appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("scaling")]
    public required bool Scaling { get; init; }

    /// <summary>
    /// Whether the button for shares appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("share")]
    public required bool Share { get; init; }

    /// <summary>
    /// Whether the button for watching later appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("watchlater")]
    public required bool Watchlater { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Buttons1
{
    /// <summary>
    /// Whether the preset includes settings for the embed button.
    /// </summary>
    [JsonPropertyName("embed")]
    public required bool Embed { get; init; }

    /// <summary>
    /// Whether the preset includes settings for the fullscreen button.
    /// </summary>
    [JsonPropertyName("fullscreen")]
    public required bool Fullscreen { get; init; }

    /// <summary>
    /// Whether the preset includes settings for the HD button.
    /// </summary>
    [JsonPropertyName("hd")]
    public required bool Hd { get; init; }

    /// <summary>
    /// Whether the preset includes settings for the like button.
    /// </summary>
    [JsonPropertyName("like")]
    public required bool Like { get; init; }

    /// <summary>
    /// Whether the preset includes settings for the reaction button.
    /// </summary>
    [JsonPropertyName("reaction")]
    public required bool? Reaction { get; init; }

    /// <summary>
    /// Whether the preset includes settings for the share button.
    /// </summary>
    [JsonPropertyName("share")]
    public required bool Share { get; init; }

    /// <summary>
    /// Whether the preset includes settings for the vote button.
    /// </summary>
    [JsonPropertyName("vote")]
    public required bool Vote { get; init; }

    /// <summary>
    /// Whether the preset includes settings for the watch later button.
    /// </summary>
    [JsonPropertyName("watchlater")]
    public required bool Watchlater { get; init; }
}

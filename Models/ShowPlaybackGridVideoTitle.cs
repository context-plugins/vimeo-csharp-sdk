using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the video title in grid view.
/// </summary>
public record ShowPlaybackGridVideoTitle
{
    /// <summary>
    /// Whether an upgrade is required to show the video title in grid view.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the video title in grid view.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

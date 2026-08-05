using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the date when the video was uploaded during playback.
/// </summary>
public record ShowPlaybackUploadedDate
{
    /// <summary>
    /// Whether an upgrade is required to show the date when the video was uploaded during playback.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the date when the video was uploaded during playback.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

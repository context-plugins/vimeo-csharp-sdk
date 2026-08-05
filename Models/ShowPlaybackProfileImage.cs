using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the profile image during playback.
/// </summary>
public record ShowPlaybackProfileImage
{
    /// <summary>
    /// Whether an upgrade is required to show the profile image during playback.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the profile image during playback.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the profile image on each video.
/// </summary>
public record ShowGridProfileImage
{
    /// <summary>
    /// Whether an upgrade is required to show the profile image on each video.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the profile image on each video.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

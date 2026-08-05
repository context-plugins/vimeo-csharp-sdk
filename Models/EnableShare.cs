using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about enabling the share functionality during playback.
/// </summary>
public record EnableShare
{
    /// <summary>
    /// Whether an upgrade is required to enable the share functionality during playback.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to enable the share functionality during playback.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

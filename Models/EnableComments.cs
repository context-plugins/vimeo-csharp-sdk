using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about enabling the comments functionality during playback.
/// </summary>
public record EnableComments
{
    /// <summary>
    /// Whether an upgrade is required to enable the comments functionality during playback.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to enable the comments functionality during playback.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

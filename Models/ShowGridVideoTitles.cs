using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the video titles below thumbnails.
/// </summary>
public record ShowGridVideoTitles
{
    /// <summary>
    /// Whether an upgrade is required to show the video titles below thumbnails.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the video titles below thumbnails.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

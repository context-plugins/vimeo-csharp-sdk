using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the video count above the video list.
/// </summary>
public record ShowGridVideoCount
{
    /// <summary>
    /// Whether an upgrade is required to show the video count above the video list.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the video count above the video list.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing video details on the showcase page.
/// </summary>
public record ShowVideoDetails
{
    /// <summary>
    /// Whether an upgrade is required to show video details on the showcase page.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show video details on the showcase page.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

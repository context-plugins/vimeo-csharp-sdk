using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the search bar in the featured content layout.
/// </summary>
public record ShowSearchBar
{
    /// <summary>
    /// Whether an upgrade is required to show the search bar in the featured content layout.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the search bar in the featured content layout.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing the banner on the showcase page.
/// </summary>
public record ShowBanner
{
    /// <summary>
    /// Whether an upgrade is required to show the banner on the showcase page.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the banner on the showcase page.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }
}

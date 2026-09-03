using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Information about showing video player cards on the showcase page.
/// </summary>
public record ShowVideoPlayerCards
{
    /// <summary>
    /// Whether an upgrade is required to show video player cards on the showcase page.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show video player cards on the showcase page.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

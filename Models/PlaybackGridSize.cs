using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Information about the grid size configuration for playback view.
/// </summary>
public record PlaybackGridSize
{
    /// <summary>
    /// Whether an upgrade is required to configure the playback grid size.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// The grid size configuration for playback view. Possible values include <c>s</c> for small, <c>m</c> for medium, <c>l</c> for large, and <c>xl</c> for extra large.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

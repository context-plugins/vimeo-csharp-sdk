using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about the grid size configuration.
/// </summary>
public record GridSize
{
    /// <summary>
    /// Whether an upgrade is required to configure the grid size.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// The grid size configuration. Possible values include <c>s</c> for small, <c>m</c> for medium, <c>l</c> for large, and <c>xl</c> for extra large.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

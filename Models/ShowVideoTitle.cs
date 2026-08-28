using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about showing the title on the showcase page.
/// </summary>
public record ShowVideoTitle
{
    /// <summary>
    /// Whether an upgrade is required to show the title on the showcase page.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the title on the showcase page.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

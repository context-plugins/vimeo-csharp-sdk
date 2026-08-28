using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about showing the showcase title.
/// </summary>
public record ShowBannerTitle
{
    /// <summary>
    /// Whether an upgrade is required to show the showcase title.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the showcase title.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Metadata about the preset.
/// </summary>
public record Metadata23
{
    /// <summary>
    /// A list of resource URIs related to the preset.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections22 Connections { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

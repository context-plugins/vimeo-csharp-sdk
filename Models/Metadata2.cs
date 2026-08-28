using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Metadata about the tag.
/// </summary>
public record Metadata2
{
    /// <summary>
    /// A collection of information that is connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections2 Connections { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

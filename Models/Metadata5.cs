using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about the folders's metadata.
/// </summary>
public record Metadata5
{
    /// <summary>
    /// A list of resource URIs related to the folder.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections5 Connections { get; init; }

    /// <summary>
    /// A list of permitted interactions related to the folder.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions4 Interactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

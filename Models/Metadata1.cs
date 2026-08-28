using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the channel.
/// </summary>
public record Metadata1
{
    /// <summary>
    /// A collection of information that is connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections1 Connections { get; init; }

    /// <summary>
    /// A list of resource URIs related to the channel.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions1? Interactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Metadata about the showcase.
/// </summary>
public record Metadata11
{
    /// <summary>
    /// Information about showcase connections.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections11 Connections { get; init; }

    /// <summary>
    /// A list of resource URIs related to the showcase.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions7? Interactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

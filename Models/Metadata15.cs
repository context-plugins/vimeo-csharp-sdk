using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the event.
/// </summary>
public record Metadata15
{
    /// <summary>
    /// A collection of information that is connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections15 Connections { get; init; }

    /// <summary>
    /// A list of resource URIs related to the event.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions10 Interactions { get; init; }
}

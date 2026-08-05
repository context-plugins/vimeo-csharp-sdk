using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the category.
/// </summary>
public record Metadata
{
    /// <summary>
    /// A collection of information that is connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections Connections { get; init; }

    /// <summary>
    /// The permissible actions related to the category.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions Interactions { get; init; }
}

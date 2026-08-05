using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the event destination.
/// </summary>
public record Metadata16
{
    /// <summary>
    /// Information about the connection status of the destination's user.
    /// </summary>
    [JsonPropertyName("connection_status")]
    public required object ConnectionStatus { get; init; }

    /// <summary>
    /// A list of resource URIs related to the event destination.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions11 Interactions { get; init; }
}

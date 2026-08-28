using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the On Demand page.
/// </summary>
public record Metadata9
{
    /// <summary>
    /// A collection of information that is connected to this resource, including videos, genres, and pictures connections.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections9 Connections { get; init; }

    /// <summary>
    /// The user's available purchase interactions.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required PurchaseInteraction Interactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

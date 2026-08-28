using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the group.
/// </summary>
public record Metadata6
{
    /// <summary>
    /// A collection of information that is connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections6 Connections { get; init; }

    /// <summary>
    /// User actions that have involved the group. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("interactions")]
    public required Interactions5 Interactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

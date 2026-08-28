using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Metadata information about the video.
/// </summary>
public record Metadata21
{
    [JsonPropertyName("connections")]
    public required Connections20 Connections { get; init; }

    [JsonPropertyName("interactions")]
    public required Interactions14 Interactions { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

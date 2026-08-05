using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata information about the video.
/// </summary>
public record Metadata21
{
    [JsonPropertyName("connections")]
    public required Connections20 Connections { get; init; }

    [JsonPropertyName("interactions")]
    public required Interactions14 Interactions { get; init; }
}

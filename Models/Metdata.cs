using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metdata
{
    [JsonPropertyName("interactions")]
    public required Interactions9 Interactions { get; init; }
}

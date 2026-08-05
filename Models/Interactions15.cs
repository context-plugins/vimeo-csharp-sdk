using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Interactions15
{
    [JsonPropertyName("purchase")]
    public required Purchase Purchase { get; init; }
}

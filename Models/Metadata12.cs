using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metadata12
{
    [JsonPropertyName("connections")]
    public required Connections12 Connections { get; init; }
}

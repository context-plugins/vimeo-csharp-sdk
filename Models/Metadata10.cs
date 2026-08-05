using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metadata10
{
    [JsonPropertyName("connections")]
    public required Connections10 Connections { get; init; }
}

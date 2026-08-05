using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metadata20
{
    [JsonPropertyName("connections")]
    public required Connections19 Connections { get; init; }
}

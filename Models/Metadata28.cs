using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metadata28
{
    [JsonPropertyName("connections")]
    public required Connections26 Connections { get; init; }
}

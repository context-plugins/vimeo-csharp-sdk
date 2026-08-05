using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metadata14
{
    [JsonPropertyName("connections")]
    public required Connections14 Connections { get; init; }
}

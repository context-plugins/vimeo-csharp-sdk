using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metadata27
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connections")]
    public Connections25? Connections { get; init; }
}

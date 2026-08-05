using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Videos17
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("video")]
    public Video6? Video { get; init; }
}

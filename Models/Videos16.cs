using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Videos16
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("video")]
    public Video5? Video { get; init; }
}

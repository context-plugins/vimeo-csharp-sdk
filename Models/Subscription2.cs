using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Subscription2
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly")]
    public Monthly? Monthly { get; init; }
}

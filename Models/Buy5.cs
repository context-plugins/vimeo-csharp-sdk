using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Buy5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public Price7? Price { get; init; }
}

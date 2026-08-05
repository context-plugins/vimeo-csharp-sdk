using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Rent5
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public Price8? Price { get; init; }
}

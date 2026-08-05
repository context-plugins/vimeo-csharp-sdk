using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Episodes1
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("buy")]
    public Buy4? Buy { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rent")]
    public Rent3? Rent { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Price3
{
    /// <summary>
    /// The purchase price per episode in United States dollars. This parameter is required when <b>episodes.buy.active</b> is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("USD")]
    public double? Usd { get; init; }
}

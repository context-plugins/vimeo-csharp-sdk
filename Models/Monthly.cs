using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Monthly
{
    /// <summary>
    /// Whether a monthly subscription is active. This parameter is required when <b>rent.active</b> and <b>buy.active</b> are <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("price")]
    public Price6? Price { get; init; }
}

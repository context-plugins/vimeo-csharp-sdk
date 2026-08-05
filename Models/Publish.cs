using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Publish
{
    /// <summary>
    /// Whether to publish the On Demand page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}

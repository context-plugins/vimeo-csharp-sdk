using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Preorder1
{
    /// <summary>
    /// Whether to enable preorders on the On Demand page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the On Demand page will be published. This parameter is required when <b>preorder.active</b> is <c>true</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("publish_time")]
    public string? PublishTime { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record LiveEventsLowLatencyRequest
{
    /// <summary>
    /// Whether the event is low latency.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("low_latency")]
    public bool? LowLatency { get; init; }
}

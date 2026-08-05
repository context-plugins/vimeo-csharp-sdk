using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record RecurringEventLowLatency
{
    /// <summary>
    /// Whether the low-latency option is enabled.
    /// </summary>
    [JsonPropertyName("lowLatency")]
    public required bool LowLatency { get; init; }
}

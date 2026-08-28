using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record RecurringEventLowLatency
{
    /// <summary>
    /// Whether the low-latency option is enabled.
    /// </summary>
    [JsonPropertyName("lowLatency")]
    public required bool LowLatency { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

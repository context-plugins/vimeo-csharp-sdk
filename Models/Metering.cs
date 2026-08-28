using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The metering status of the live video.
/// </summary>
public record Metering
{
    /// <summary>
    /// The maximum number of seconds.
    /// </summary>
    [JsonPropertyName("seconds_max")]
    public required double SecondsMax { get; init; }

    /// <summary>
    /// The number of seconds remaining.
    /// </summary>
    [JsonPropertyName("seconds_remaining")]
    public required double SecondsRemaining { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

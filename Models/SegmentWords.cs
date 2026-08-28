using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record SegmentWords
{
    /// <summary>
    /// The end time of the word in milliseconds.
    /// </summary>
    [JsonPropertyName("end_time")]
    public required double? EndTime { get; init; }

    /// <summary>
    /// The start time of the word in milliseconds.
    /// </summary>
    [JsonPropertyName("start_time")]
    public required double? StartTime { get; init; }

    /// <summary>
    /// The word text.
    /// </summary>
    [JsonPropertyName("word")]
    public required string Word { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Segment1
{
    /// <summary>
    /// The end time in milliseconds. Must be non-negative. Cannot overlap with the next segment's start time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public double? EndTime { get; init; }

    /// <summary>
    /// The segment UUID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    /// <summary>
    /// The start time in milliseconds. Must be non-negative and less than <c>end_time</c>. Cannot overlap with the previous segment's end time.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_time")]
    public double? StartTime { get; init; }

    /// <summary>
    /// The updated text for the segment. Required for text edits; omit for timestamp-only changes.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("text")]
    public string? Text { get; init; }
}

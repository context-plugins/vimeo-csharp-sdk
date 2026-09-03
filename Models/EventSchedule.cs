using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record EventSchedule
{
    /// <summary>
    /// The time in ISO 8601 format when the event is expected to end.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }

    /// <summary>
    /// The recurrence rule for the event's schedule according to <see href="https://datatracker.ietf.org/doc/html/rfc5545">RFC 5545</see>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rrule")]
    public string? Rrule { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the event is expected to be live.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_time")]
    public string? StartTime { get; init; }

    /// <summary>
    /// The time zone of the event.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_zone")]
    public string? TimeZone { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

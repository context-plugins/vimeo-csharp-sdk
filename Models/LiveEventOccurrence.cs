using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record LiveEventOccurrence
{
    /// <summary>
    /// The end time of this occurrence in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("end_time")]
    public required string? EndTime { get; init; }

    /// <summary>
    /// The full live event resource that owns this occurrence. Use sub-fields (e.g. <c>event.parentFolder</c>, <c>event.pictures</c>, <c>event.metadata.interactions.delete</c>) to opt into specific event data without paying for the full event payload.
    /// </summary>
    [JsonPropertyName("event")]
    public required RecurringEvent? Event { get; init; }

    /// <summary>
    /// The title of the live event.
    /// </summary>
    [JsonPropertyName("event_title")]
    public required string EventTitle { get; init; }

    /// <summary>
    /// The type of the live event.
    /// </summary>
    [JsonPropertyName("event_type")]
    public required string EventType { get; init; }

    /// <summary>
    /// The URI of the parent live event.
    /// </summary>
    [JsonPropertyName("event_uri")]
    public required string EventUri { get; init; }

    /// <summary>
    /// Whether the event has registration enabled.
    /// </summary>
    [JsonPropertyName("has_registration")]
    public required bool HasRegistration { get; init; }

    /// <summary>
    /// The URI to access the event on Vimeo.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The URI to access the event settings.
    /// </summary>
    [JsonPropertyName("settings_link")]
    public required string? SettingsLink { get; init; }

    /// <summary>
    /// The start time of this occurrence in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("start_time")]
    public required string StartTime { get; init; }

    /// <summary>
    /// The status of the live event.
    /// </summary>
    [JsonPropertyName("status")]
    public required string Status { get; init; }

    /// <summary>
    /// The thumbnail URL of the live event.
    /// </summary>
    [JsonPropertyName("thumbnail")]
    public required string? Thumbnail { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record OttDestination
{
    /// <summary>
    /// The OTT destination's canonical relative URI.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The ID of the OTT channel.
    /// </summary>
    [JsonPropertyName("ott_channel_id")]
    public required double OttChannelId { get; init; }

    /// <summary>
    /// The name of the OTT channel.
    /// </summary>
    [JsonPropertyName("ott_channel_name")]
    public required string OttChannelName { get; init; }

    /// <summary>
    /// The subdomain of the OTT channel.
    /// </summary>
    [JsonPropertyName("ott_channel_subdomain")]
    public required string OttChannelSubdomain { get; init; }

    /// <summary>
    /// The ID of the OTT event.
    /// </summary>
    [JsonPropertyName("ott_event_id")]
    public required double OttEventId { get; init; }

    /// <summary>
    /// The ID of the current recurring event.
    /// </summary>
    [JsonPropertyName("recurring_live_event_id")]
    public required double RecurringLiveEventId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

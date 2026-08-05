using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Card
{
    /// <summary>
    /// The number of seconds for which the card appears.
    /// </summary>
    [JsonPropertyName("display_time")]
    public required double DisplayTime { get; init; }

    /// <summary>
    /// The title of the card.
    /// </summary>
    [JsonPropertyName("headline")]
    public required string Headline { get; init; }

    /// <summary>
    /// The UUID of the card.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The URL of the thumbnail for the card.
    /// </summary>
    [JsonPropertyName("image_url")]
    public required string ImageUrl { get; init; }

    /// <summary>
    /// The description of the card.
    /// </summary>
    [JsonPropertyName("teaser")]
    public required string Teaser { get; init; }

    /// <summary>
    /// The playback timestamp, given in seconds, when the card appears.
    /// </summary>
    [JsonPropertyName("timecode")]
    public required double Timecode { get; init; }

    /// <summary>
    /// The URL of the card.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; init; }
}

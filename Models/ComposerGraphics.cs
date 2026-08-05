using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ComposerGraphics
{
    /// <summary>
    /// The timestamp in milliseconds since the Unix epoch when the item was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required double CreatedAt { get; init; }

    /// <summary>
    /// The unique identifier of the graphic item.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The type of the graphic item. The value of this field is always <c>agoraMedia</c> for this object.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// The timestamp in milliseconds since the Unix epoch when the item was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required double UpdatedAt { get; init; }

    /// <summary>
    /// The length of the video in seconds.
    /// </summary>
    [JsonPropertyName("videoDuration")]
    public required double VideoDuration { get; init; }

    /// <summary>
    /// The unique identifier of the video resource.
    /// </summary>
    [JsonPropertyName("videoId")]
    public required double VideoId { get; init; }

    /// <summary>
    /// The URL to the standard-resolution video thumbnail image.
    /// </summary>
    [JsonPropertyName("videoThumb")]
    public required string VideoThumb { get; init; }

    /// <summary>
    /// The URL to the high-resolution video thumbnail image.
    /// </summary>
    [JsonPropertyName("videoThumbFullSize")]
    public required string VideoThumbFullSize { get; init; }
}

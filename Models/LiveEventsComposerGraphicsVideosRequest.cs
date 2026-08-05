using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record LiveEventsComposerGraphicsVideosRequest
{
    /// <summary>
    /// The ID of the associated video.
    /// </summary>
    [JsonPropertyName("video_id")]
    public required double VideoId { get; init; }
}

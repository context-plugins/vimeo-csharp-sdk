using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ChannelsVideosRequest
{
    /// <summary>
    /// The URI of a video to remove.
    /// </summary>
    [JsonPropertyName("video_uri")]
    public required string VideoUri { get; init; }
}

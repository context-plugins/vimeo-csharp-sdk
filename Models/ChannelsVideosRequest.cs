using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record ChannelsVideosRequest
{
    /// <summary>
    /// The URI of a video to remove.
    /// </summary>
    [JsonPropertyName("video_uri")]
    public required string VideoUri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

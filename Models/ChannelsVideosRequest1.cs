using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ChannelsVideosRequest1
{
    /// <summary>
    /// A member of an array representing the URIs of the videos to add. For each member in the array, use the format <c>{"video_uri":"x"}</c> where <b>x</b> is a video URI. For more information on batch requests like this, see <see href="https://developer.vimeo.com/api/common-formats#working-with-batch-requests">Using Common Formats and Parameters</see>.
    /// </summary>
    [JsonPropertyName("video_uri")]
    public required string VideoUri { get; init; }
}

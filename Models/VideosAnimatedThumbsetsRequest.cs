using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosAnimatedThumbsetsRequest
{
    /// <summary>
    /// The duration of the animation in seconds. The maximum value is 6.
    /// </summary>
    [JsonPropertyName("duration")]
    public required double Duration { get; init; }

    /// <summary>
    /// The time in seconds corresponding to the start of the animation in the video. The default value is 0.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_time")]
    public double? StartTime { get; init; }
}

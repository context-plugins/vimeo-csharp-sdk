using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosTrimRequest
{
    /// <summary>
    /// The end position in seconds of the trim in the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trim_end")]
    public string? TrimEnd { get; init; }

    /// <summary>
    /// The start position in seconds of the trim in the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("trim_start")]
    public string? TrimStart { get; init; }
}

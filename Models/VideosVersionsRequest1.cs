using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosVersionsRequest1
{
    /// <summary>
    /// A description of the video version. This description can make use of the full unicode character set.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Whether the video version is active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_current")]
    public bool? IsCurrent { get; init; }
}

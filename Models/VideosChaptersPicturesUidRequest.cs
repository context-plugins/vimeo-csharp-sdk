using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosChaptersPicturesUidRequest
{
    /// <summary>
    /// Whether to set the chapter thumbnail as active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}

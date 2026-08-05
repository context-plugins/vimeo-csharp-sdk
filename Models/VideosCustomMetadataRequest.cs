using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosCustomMetadataRequest
{
    /// <summary>
    /// The custom metadata values to apply to the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("fields")]
    public IReadOnlyList<Field1>? Fields { get; init; }
}

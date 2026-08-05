using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosAiTexttracksRequest
{
    /// <summary>
    /// The segments to edit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("segments")]
    public IReadOnlyList<Segment1>? Segments { get; init; }
}

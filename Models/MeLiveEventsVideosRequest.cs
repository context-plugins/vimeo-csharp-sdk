using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record MeLiveEventsVideosRequest
{
    /// <summary>
    /// An array of video objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("videos")]
    public IReadOnlyList<Videos16>? Videos { get; init; }
}

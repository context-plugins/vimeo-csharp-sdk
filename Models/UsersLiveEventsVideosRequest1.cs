using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersLiveEventsVideosRequest1
{
    /// <summary>
    /// An array of video objects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("videos")]
    public IReadOnlyList<Videos17>? Videos { get; init; }
}

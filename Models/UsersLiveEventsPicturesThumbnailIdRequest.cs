using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersLiveEventsPicturesThumbnailIdRequest
{
    /// <summary>
    /// Whether the thumbnail is the event's active thumbnail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}

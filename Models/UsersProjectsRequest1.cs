using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersProjectsRequest1
{
    /// <summary>
    /// When true and should_delete_clips is true, deleted videos use the Recently Deleted purgatory bucket (30-day retention).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("send_to_recently_deleted")]
    public bool? SendToRecentlyDeleted { get; init; }

    /// <summary>
    /// Whether to delete all the videos in the folder along with the folder itself.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("should_delete_clips")]
    public bool? ShouldDeleteClips { get; init; }
}

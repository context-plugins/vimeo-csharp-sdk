using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersProjectsVideosRequest
{
    /// <summary>
    /// When deleting clips, use Recently Deleted purgatory when true.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("send_to_recently_deleted")]
    public bool? SendToRecentlyDeleted { get; init; }

    /// <summary>
    /// Whether to delete the videos when removing them from the folder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("should_delete_clips")]
    public bool? ShouldDeleteClips { get; init; }

    /// <summary>
    /// A comma-separated list of the video URIs to remove.
    /// </summary>
    [JsonPropertyName("uris")]
    public required string Uris { get; init; }
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record VideosRequest
{
    /// <summary>
    /// When true, the video is placed in the Recently Deleted purgatory bucket (30-day retention). When false or omitted, legacy user-delete purgatory applies.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("send_to_recently_deleted")]
    public bool? SendToRecentlyDeleted { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

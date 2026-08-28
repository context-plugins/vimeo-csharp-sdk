using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record MeVideosRequest
{
    /// <summary>
    /// When true, deleted videos use the Recently Deleted purgatory bucket (30-day retention).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("send_to_recently_deleted")]
    public bool? SendToRecentlyDeleted { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record LiveEventsComposerGraphicsVideosRequest
{
    /// <summary>
    /// The ID of the associated video.
    /// </summary>
    [JsonPropertyName("video_id")]
    public required double VideoId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

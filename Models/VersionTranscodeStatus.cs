using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record VersionTranscodeStatus
{
    /// <summary>
    /// Whether the video has finished transcoding.
    /// </summary>
    [JsonPropertyName("is_complete")]
    public required bool IsComplete { get; init; }

    /// <summary>
    /// Whether the video is playable in all resolutions, up to either the source quality or 4K, whichever is lower, at standard definition.
    /// </summary>
    [JsonPropertyName("is_fully_playable")]
    public required bool IsFullyPlayable { get; init; }

    /// <summary>
    /// Whether the video is playable.
    /// </summary>
    [JsonPropertyName("is_playable")]
    public required bool IsPlayable { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

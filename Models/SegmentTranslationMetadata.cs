using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record SegmentTranslationMetadata
{
    /// <summary>
    /// Whether the audio of the translation's segment is out of sync.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audio_out_of_sync")]
    public bool? AudioOutOfSync { get; init; }

    /// <summary>
    /// The ID of the translation's audio track.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audio_track_id")]
    public string? AudioTrackId { get; init; }

    /// <summary>
    /// The translation language in ISO 639-1 format.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dominant_language")]
    public string? DominantLanguage { get; init; }

    /// <summary>
    /// The vendor ID of the translation's dubbing.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dubbing_id")]
    public string? DubbingId { get; init; }

    /// <summary>
    /// The vendor ID of the translation's segment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dubbing_segment_id")]
    public string? DubbingSegmentId { get; init; }

    /// <summary>
    /// Whether the translation's segment is out of sync.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("translation_out_of_sync")]
    public bool? TranslationOutOfSync { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record TrimmedVideo
{
    /// <summary>
    /// The ID of the video. _This field is deprecated._
    /// </summary>
    [JsonPropertyName("clip_id")]
    public required double ClipId { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the trim was created.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// The most recent version of the trimmed video. _This field is deprecated._
    /// </summary>
    [JsonPropertyName("created_version_id")]
    public required string CreatedVersionId { get; init; }

    /// <summary>
    /// The end of the trim from the last trim, in seconds.
    /// </summary>
    [JsonPropertyName("end")]
    public required string End { get; init; }

    /// <summary>
    /// Whether the transcoding jobs for the video file have finished. _This field is deprecated._
    /// </summary>
    [JsonPropertyName("is_clip_finished_transcoding")]
    public required bool IsClipFinishedTranscoding { get; init; }

    [JsonPropertyName("metadata")]
    public required Metadata28 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the trim policy was last modified.
    /// </summary>
    [JsonPropertyName("modified_on")]
    public required string? ModifiedOn { get; init; }

    /// <summary>
    /// The video version that is the source of the trimmed video. _This field is deprecated._
    /// </summary>
    [JsonPropertyName("root_version_id")]
    public required string RootVersionId { get; init; }

    /// <summary>
    /// The start of the trim from the last trim, in seconds.
    /// </summary>
    [JsonPropertyName("start")]
    public required string Start { get; init; }

    /// <summary>
    /// The URI of the player or the trim service. _This field is deprecated._
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The quality of the root version video file.
    /// </summary>
    [JsonPropertyName("version_quality")]
    public required string VersionQuality { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

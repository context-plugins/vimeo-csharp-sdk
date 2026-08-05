using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about where and how to create a highlight for the video.
/// </summary>
public record Highlights
{
    /// <summary>
    /// Whether the interaction is disabled for the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled")]
    public bool? Disabled { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The reason why the interaction is disabled.
    /// <para>
    /// Option descriptions:
    ///  * <c>owner_disabled_feature_group</c> - The owner has disabled the feature group.
    ///  * <c>transcript_status_does_not_exist</c> - The transcript doesn't exist.
    ///  * <c>transcript_status_failed</c> - The transcript job failed.
    ///  * <c>transcript_status_in_progress</c> - The transcript job is in progress.
    ///  * <c>transcript_status_no_speech</c> - There's no speech detected for the transcript.
    ///  * <c>transcript_status_not_started</c> - The transcript job hasn't started.
    ///  * <c>transcript_status_unknown</c> - The transcript job status is unknown.
    ///  * <c>video_not_ready</c> - The video isn't ready.
    ///  * <c>video_resolution_too_low</c> - The video resolution is below the 360p minimum requirement.
    ///  * <c>video_too_short</c> - The video is too short.
    ///  * <c>video_transcript_too_short</c> - The video transcript is too short.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("reason")]
    public Reason5? Reason { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

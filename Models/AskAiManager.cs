using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about where and how to submit questions by managers to the AI service for this video.
/// </summary>
public record AskAiManager
{
    /// <summary>
    /// Whether the summary method is disabled.
    /// </summary>
    [JsonPropertyName("disabled")]
    public required bool Disabled { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The reason why the summary method is disabled.
    /// <para>
    /// Option descriptions:
    ///  * <c>transcript_ready_but_not_english</c> - The transcript is ready, but it isn't in English.
    ///  * <c>transcript_status_does_not_exist</c> - The transcript doesn't exist.
    ///  * <c>transcript_status_exceeds_maximum_duration</c> - The transcript duration is too long.
    ///  * <c>transcript_status_failed</c> - The transcript job failed.
    ///  * <c>transcript_status_in_progress</c> - The transcript job is in progress.
    ///  * <c>transcript_status_language_not_supported</c> - The transcript's language isn't supported.
    ///  * <c>transcript_status_no_speech</c> - There's no speech detected for the transcript.
    ///  * <c>transcript_status_not_started</c> - The transcript job hasn't started.
    ///  * <c>transcript_status_unknown</c> - The transcript job status is unknown.
    ///  * <c>video_not_ready</c> - The video isn't ready.
    ///  * <c>video_too_short</c> - The video is too short.
    ///  * <c>video_transcript_too_short</c> - The video transcript is too short.
    /// </para>
    /// </summary>
    [JsonPropertyName("reason")]
    public required Reason3? Reason { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

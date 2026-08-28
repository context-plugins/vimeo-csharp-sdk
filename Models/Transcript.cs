using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The transcript information of the video. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record Transcript
{
    /// <summary>
    /// The video transcript's language. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("language")]
    public required string? Language { get; init; }

    /// <summary>
    /// The video transcript's availability status. This data requires a bearer token with the <c>private</c> scope.
    /// <para>
    /// Option descriptions:
    ///  * <c>blocked</c> - The transcription is blocked.
    ///  * <c>completed</c> - Transcription is completed. The transcript is available.
    ///  * <c>exceeds_maximum_duration</c> - The audio track is too long to be transcribed.
    ///  * <c>failed</c> - There was a transcription error. The transcript isn't available.
    ///  * <c>in_progress</c> - Transcription is currently underway. The transcript isn't available yet.
    ///  * <c>language_not_supported</c> - We currently don't support transcribing audio for this video's language.
    ///  * <c>no_speech</c> - Transcription was completed, but there were no words in the audio to transcribe.
    ///  * <c>not_started</c> - The transcript job hasn't started.
    ///  * <c>unknown</c> - There isn't a record of this video's transcription job.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status7? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

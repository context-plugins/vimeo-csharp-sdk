using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The reason why Ask AI is disabled.
/// <para>
/// Option descriptions:
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
[JsonConverter(typeof(StringEnumConverter<Reason4>))]
public sealed record Reason4 : StringEnum<Reason4>
{
    private Reason4(string value) : base(value)
    {
    }

    public static readonly Reason4 TranscriptStatusDoesNotExist = new("transcript_status_does_not_exist");

    public static readonly Reason4 TranscriptStatusExceedsMaximumDuration = new("transcript_status_exceeds_maximum_duration");

    public static readonly Reason4 TranscriptStatusFailed = new("transcript_status_failed");

    public static readonly Reason4 TranscriptStatusInProgress = new("transcript_status_in_progress");

    public static readonly Reason4 TranscriptStatusLanguageNotSupported = new("transcript_status_language_not_supported");

    public static readonly Reason4 TranscriptStatusNoSpeech = new("transcript_status_no_speech");

    public static readonly Reason4 TranscriptStatusNotStarted = new("transcript_status_not_started");

    public static readonly Reason4 TranscriptStatusUnknown = new("transcript_status_unknown");

    public static readonly Reason4 VideoNotReady = new("video_not_ready");

    public static readonly Reason4 VideoTooShort = new("video_too_short");

    public static readonly Reason4 VideoTranscriptTooShort = new("video_transcript_too_short");

    public static Reason4 FromValue(string value) => FromValueCore(value);
}

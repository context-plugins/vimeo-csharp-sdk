using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Reason5>))]
public sealed record Reason5 : StringEnum<Reason5>
{
    private Reason5(string value) : base(value)
    {
    }

    public static readonly Reason5 OwnerDisabledFeatureGroup = new("owner_disabled_feature_group");

    public static readonly Reason5 TranscriptStatusDoesNotExist = new("transcript_status_does_not_exist");

    public static readonly Reason5 TranscriptStatusFailed = new("transcript_status_failed");

    public static readonly Reason5 TranscriptStatusInProgress = new("transcript_status_in_progress");

    public static readonly Reason5 TranscriptStatusNoSpeech = new("transcript_status_no_speech");

    public static readonly Reason5 TranscriptStatusNotStarted = new("transcript_status_not_started");

    public static readonly Reason5 TranscriptStatusUnknown = new("transcript_status_unknown");

    public static readonly Reason5 VideoNotReady = new("video_not_ready");

    public static readonly Reason5 VideoResolutionTooLow = new("video_resolution_too_low");

    public static readonly Reason5 VideoTooShort = new("video_too_short");

    public static readonly Reason5 VideoTranscriptTooShort = new("video_transcript_too_short");

    public static Reason5 FromValue(string value) => FromValueCore(value);
}

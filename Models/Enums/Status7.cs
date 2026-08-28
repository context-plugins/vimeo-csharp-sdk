using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Status7>))]
public sealed record Status7 : StringEnum<Status7>
{
    private Status7(string value) : base(value)
    {
    }

    public static readonly Status7 Blocked = new("blocked");

    public static readonly Status7 Completed = new("completed");

    public static readonly Status7 ExceedsMaximumDuration = new("exceeds_maximum_duration");

    public static readonly Status7 Failed = new("failed");

    public static readonly Status7 InProgress = new("in_progress");

    public static readonly Status7 LanguageNotSupported = new("language_not_supported");

    public static readonly Status7 NoSpeech = new("no_speech");

    public static readonly Status7 NotStarted = new("not_started");

    public static readonly Status7 Unknown = new("unknown");

    public static Status7 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The type of event that triggers the webhook.
/// <para>
/// Option descriptions:
///  * <c>automatic-thumbnail-available</c> - The webhook is called when the automatically generated thumbnail is available.
///  * <c>content-scan-completed</c> - The webhook is called when content moderation scan results are available.
///  * <c>live-event-archive-available</c> - The webhook is called when an archive of the event is available.
///  * <c>live-event-clip-created</c> - The webhook is called when a new video of the event is created.
///  * <c>live-event-deleted</c> - The webhook is called when an event is deleted.
///  * <c>live-event-ended</c> - The webhook is called when an event is ended.
///  * <c>live-event-started</c> - The webhook is called when an event is started.
///  * <c>live-event-updated</c> - The webhook is called when an event is updated.
///  * <c>transcript-status-complete</c> - The webhook is called when a transcript status is either <c>completed</c> or <c>failed</c>.
///  * <c>transcript-status-updated</c> - The webhook is called when a transcript status is updated.
///  * <c>video-created</c> - The webhook is called when a video is created.
///  * <c>video-deleted</c> - The webhook is called when a video is deleted.
///  * <c>video-transcode-complete</c> - The webhook is called when a video finishes transcoding.
///  * <c>video-transcode-fully-playable</c> - The webhook is called when a video is playable in all resolutions, up to either the source quality or 4K, whichever is lower, at standard definition.
///  * <c>video-transcode-playable</c> - The webhook is called when a video is playable.
///  * <c>video-updated</c> - The webhook is called when a video is updated.
///  * <c>video-upload-failed</c> - The webhook is called when a video upload fails.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<WebhookType1>))]
public sealed record WebhookType1 : StringEnum<WebhookType1>
{
    private WebhookType1(string value) : base(value)
    {
    }

    public static readonly WebhookType1 AutomaticThumbnailAvailable = new("automatic-thumbnail-available");

    public static readonly WebhookType1 ContentScanCompleted = new("content-scan-completed");

    public static readonly WebhookType1 LiveEventArchiveAvailable = new("live-event-archive-available");

    public static readonly WebhookType1 LiveEventClipCreated = new("live-event-clip-created");

    public static readonly WebhookType1 LiveEventDeleted = new("live-event-deleted");

    public static readonly WebhookType1 LiveEventEnded = new("live-event-ended");

    public static readonly WebhookType1 LiveEventStarted = new("live-event-started");

    public static readonly WebhookType1 LiveEventUpdated = new("live-event-updated");

    public static readonly WebhookType1 TranscriptStatusComplete = new("transcript-status-complete");

    public static readonly WebhookType1 TranscriptStatusUpdated = new("transcript-status-updated");

    public static readonly WebhookType1 VideoCreated = new("video-created");

    public static readonly WebhookType1 VideoDeleted = new("video-deleted");

    public static readonly WebhookType1 VideoTranscodeComplete = new("video-transcode-complete");

    public static readonly WebhookType1 VideoTranscodeFullyPlayable = new("video-transcode-fully-playable");

    public static readonly WebhookType1 VideoTranscodePlayable = new("video-transcode-playable");

    public static readonly WebhookType1 VideoUpdated = new("video-updated");

    public static readonly WebhookType1 VideoUploadFailed = new("video-upload-failed");

    public static WebhookType1 FromValue(string value) => FromValueCore(value);
}

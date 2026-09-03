using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of event that triggers the webhook.
/// <para>
/// Option descriptions:
///  * <c>automatic-thumbnail-available</c> - The webhook is called when the automatically generated thumbnail is available.
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
[JsonConverter(typeof(StringEnumConverter<WebhookType>))]
public sealed record WebhookType : StringEnum<WebhookType>
{
    private WebhookType(string value) : base(value)
    {
    }

    public static readonly WebhookType AutomaticThumbnailAvailable = new("automatic-thumbnail-available");

    public static readonly WebhookType LiveEventArchiveAvailable = new("live-event-archive-available");

    public static readonly WebhookType LiveEventClipCreated = new("live-event-clip-created");

    public static readonly WebhookType LiveEventDeleted = new("live-event-deleted");

    public static readonly WebhookType LiveEventEnded = new("live-event-ended");

    public static readonly WebhookType LiveEventStarted = new("live-event-started");

    public static readonly WebhookType LiveEventUpdated = new("live-event-updated");

    public static readonly WebhookType TranscriptStatusComplete = new("transcript-status-complete");

    public static readonly WebhookType TranscriptStatusUpdated = new("transcript-status-updated");

    public static readonly WebhookType VideoCreated = new("video-created");

    public static readonly WebhookType VideoDeleted = new("video-deleted");

    public static readonly WebhookType VideoTranscodeComplete = new("video-transcode-complete");

    public static readonly WebhookType VideoTranscodeFullyPlayable = new("video-transcode-fully-playable");

    public static readonly WebhookType VideoTranscodePlayable = new("video-transcode-playable");

    public static readonly WebhookType VideoUpdated = new("video-updated");

    public static readonly WebhookType VideoUploadFailed = new("video-upload-failed");

    public static WebhookType FromValue(string value) => FromValueCore(value);
}

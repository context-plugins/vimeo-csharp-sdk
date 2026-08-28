using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record AppsWebhooksRequest
{
    /// <summary>
    /// Whether the webhook is activated. The default value is <c>false</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }

    /// <summary>
    /// The secret key that is passed on webhook payloads. The null value means that no secret key is passed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook_type")]
    public WebhookType1? WebhookType { get; init; }

    /// <summary>
    /// The URL to which data is sent.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("webhook_url")]
    public string? WebhookUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

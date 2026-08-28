using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record ApiAppWebhook
{
    /// <summary>
    /// The URI of the API app for which the webhook is created.
    /// </summary>
    [JsonPropertyName("app_uri")]
    public required double AppUri { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the webhook was created.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the webhook was most recently disabled. If this field isn't present in the response, the webhook isn't disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled_on")]
    public string? DisabledOn { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the webhook was most recently enabled. If this field doesn't appear in the response, the webhook is disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("enabled_on")]
    public string? EnabledOn { get; init; }

    /// <summary>
    /// The failure error rate at the time that the webhook was most recently disabled. If this field doesn't appear in the response, the webhook wasn't disabled after being active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("failure_rate_before_disabling")]
    public double? FailureRateBeforeDisabling { get; init; }

    /// <summary>
    /// Whether the webhook is activated.
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public required bool IsEnabled { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the last request to the webhook URL was made before the webhook was disabled. If this field doesn't appear in the response, the webhook wasn't disabled after being active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_request_time_before_disabling")]
    public string? LastRequestTimeBeforeDisabling { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the webhook was most recently modified.
    /// </summary>
    [JsonPropertyName("modified_on")]
    public required string ModifiedOn { get; init; }

    /// <summary>
    /// The number of requests that were executed before the webhook was most recently disabled. If this field doesn't appear in the response, the webhook wasn't disabled after being active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requests_executed_before_disabling")]
    public double? RequestsExecutedBeforeDisabling { get; init; }

    /// <summary>
    /// The number of requests that failed before the webhook was most recently disabled. If this field doesn't appear in the response, the webhook wasn't disabled after being active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("requests_failed_before_disabling")]
    public double? RequestsFailedBeforeDisabling { get; init; }

    /// <summary>
    /// The secret key that is passed on webhook payloads. If this field isn't present in the response, no secret key is passed.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("secret")]
    public string? Secret { get; init; }

    /// <summary>
    /// The time period in seconds over which requests were executed before the webhook was most recently disabled. If this field doesn't appear in the response, the webhook wasn't disabled after being active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_period_failure_rate")]
    public double? TimePeriodFailureRate { get; init; }

    /// <summary>
    /// The URI of the webhook.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

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
    [JsonPropertyName("webhook_type")]
    public required WebhookType WebhookType { get; init; }

    /// <summary>
    /// The URL to which data is sent when the webhook is triggered.
    /// </summary>
    [JsonPropertyName("webhook_url")]
    public required string WebhookUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

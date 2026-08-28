using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// The ingest of the video.
/// </summary>
public record Ingest
{
    /// <summary>
    /// The protocol used for this session.
    /// <para>
    /// Option descriptions:
    ///  * <c>dash</c> - The protocol is DASH.
    ///  * <c>rtmp</c> - The protocol is RTMP.
    ///  * <c>simple_live</c> - The protocol is Simplelive.
    ///  * <c>srt</c> - The protocol is SRT.
    ///  * <c>studio_cloud</c> - The protocol is StudioCloud.
    ///  * <c>unknown</c> - The protocol is unknown or not set.
    ///  * <c>webrtc</c> - The protocol is WebRTC.
    /// </para>
    /// </summary>
    [JsonPropertyName("encoder_type")]
    public required EncoderType EncoderType { get; init; }

    /// <summary>
    /// The timestamp in UTC format when the live stream ended.
    /// </summary>
    [JsonPropertyName("end_time")]
    public required double? EndTime { get; init; }

    /// <summary>
    /// The height of the live video in pixels.
    /// </summary>
    [JsonPropertyName("height")]
    public required double? Height { get; init; }

    /// <summary>
    /// Whether the session is using RTMP.
    /// </summary>
    [JsonPropertyName("is_rtmp_session")]
    public required bool IsRtmpSession { get; init; }

    /// <summary>
    /// Whether the stream is scheduled media playback.
    /// </summary>
    [JsonPropertyName("is_scheduled_playback")]
    public required bool? IsScheduledPlayback { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the RTMP expires.
    /// </summary>
    [JsonPropertyName("rtmp_expires_at")]
    public required string? RtmpExpiresAt { get; init; }

    /// <summary>
    /// The upstream RTMP link. Send your live content to this link to create a live video on the event.
    /// </summary>
    [JsonPropertyName("rtmp_link")]
    public required string? RtmpLink { get; init; }

    /// <summary>
    /// The upstream RTMPS link. Send your live content to this secure link to create a live video on the event.
    /// </summary>
    [JsonPropertyName("rtmps_link")]
    public required string? RtmpsLink { get; init; }

    /// <summary>
    /// The scheduled start time of the live video in ISO 8601 format.
    /// </summary>
    [JsonPropertyName("scheduled_start_time")]
    public required string? ScheduledStartTime { get; init; }

    /// <summary>
    /// The session ID.
    /// </summary>
    [JsonPropertyName("session_id")]
    public required string? SessionId { get; init; }

    /// <summary>
    /// The timestamp in UTC format when the live video started.
    /// </summary>
    [JsonPropertyName("start_time")]
    public required double? StartTime { get; init; }

    /// <summary>
    /// The ingest status of the live video.
    /// <para>
    /// Option descriptions:
    ///  * <c>0</c> - There’s a live video, but no RMTP URL or key.
    ///  * <c>1</c> - There’s an RMTP URL and key, but the machine is provisioning.
    ///  * <c>2</c> - There’s an RMTP URL and key, and the machine is provisioned, but the stream hasn’t started yet.
    ///  * <c>3</c> - There’s an RMTP URL and key, and the machine is provisioned, but the stream didn’t start before the machine timed out.
    ///  * <c>4</c> - The stream has started and is currently underway.
    ///  * <c>5</c> - The stream has ended.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status14? Status { get; init; }

    /// <summary>
    /// The reason why the stream ended. If the stream hasn't ended, this field is empty.
    /// </summary>
    [JsonPropertyName("stream_ended_reason")]
    public required double? StreamEndedReason { get; init; }

    /// <summary>
    /// The stream key used in conjunction with the RTMP and RTMPS links.
    /// </summary>
    [JsonPropertyName("stream_key")]
    public required string? StreamKey { get; init; }

    /// <summary>
    /// The width of the live video in pixels.
    /// </summary>
    [JsonPropertyName("width")]
    public required double? Width { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

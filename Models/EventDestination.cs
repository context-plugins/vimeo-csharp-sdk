using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record EventDestination
{
    /// <summary>
    /// The name of the destination target, whether a page, profile name, or the like.
    /// </summary>
    [JsonPropertyName("display_name")]
    public required string DisplayName { get; init; }

    /// <summary>
    /// The ID of the destination.
    /// </summary>
    [JsonPropertyName("id")]
    public required double Id { get; init; }

    /// <summary>
    /// Whether the destination is enabled.
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public required bool IsEnabled { get; init; }

    /// <summary>
    /// The ID of the live video.
    /// </summary>
    [JsonPropertyName("live_clip_id")]
    public required double LiveClipId { get; init; }

    /// <summary>
    /// Metadata about the event destination.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata16 Metadata { get; init; }

    /// <summary>
    /// The privacy setting of the destination.
    /// <para>
    /// Option descriptions:
    ///  * <c>CONNECTIONS</c> - The privacy setting is <c>CONNECTIONS</c> for LinkedIn.
    ///  * <c>PUBLIC</c> - The privacy setting is <c>PUBLIC</c> for LinkedIn.
    ///  * <c>all_friends</c> - The privacy setting is <c>all_friends</c> for Facebook.
    ///  * <c>everyone</c> - The privacy setting is <c>everyone</c> for Facebook.
    ///  * <c>private</c> - The privacy setting is <c>private</c> for YouTube.
    ///  * <c>public</c> - The privacy setting is <c>public</c> for YouTube.
    ///  * <c>self</c> - The privacy setting is <c>self</c> for Facebook.
    ///  * <c>unlisted</c> - The privacy setting is <c>unlisted</c> for YouTube.
    /// </para>
    /// </summary>
    [JsonPropertyName("privacy")]
    public required Privacy6? Privacy { get; init; }

    /// <summary>
    /// The broadcast ID of the destination service.
    /// </summary>
    [JsonPropertyName("provider_broadcast_id")]
    public required string? ProviderBroadcastId { get; init; }

    /// <summary>
    /// The destination ID of the destination service.
    /// </summary>
    [JsonPropertyName("provider_destination_id")]
    public required string? ProviderDestinationId { get; init; }

    /// <summary>
    /// The user ID of the destination service.
    /// </summary>
    [JsonPropertyName("provider_user_id")]
    public required string? ProviderUserId { get; init; }

    /// <summary>
    /// The ID of the scheduled live video.
    /// </summary>
    [JsonPropertyName("provider_video_id")]
    public required string? ProviderVideoId { get; init; }

    /// <summary>
    /// The time in Unix timestamp format when live streaming is scheduled to start.
    /// </summary>
    [JsonPropertyName("scheduled_at")]
    public required double? ScheduledAt { get; init; }

    /// <summary>
    /// The name of the destination service.
    /// <para>
    /// Option descriptions:
    ///  * <c>custom_rtmp</c> - The destination service is custom RTMP.
    ///  * <c>facebook</c> - The destination service is Facebook Live.
    ///  * <c>linkedin</c> - The destination service is LinkedIn Live.
    ///  * <c>youtube</c> - The destination service is YouTube Live.
    /// </para>
    /// </summary>
    [JsonPropertyName("service_name")]
    public required ServiceName ServiceName { get; init; }

    /// <summary>
    /// The status of the destination.
    /// <para>
    /// Option descriptions:
    ///  * <c>0</c> - The status is OK.
    ///  * <c>1</c> - An error occurred. Check the <c>state_message</c> field for details.
    /// </para>
    /// </summary>
    [JsonPropertyName("state")]
    public required State State { get; init; }

    /// <summary>
    /// The message that describes the state of the destination.
    /// </summary>
    [JsonPropertyName("state_message")]
    public required string? StateMessage { get; init; }

    /// <summary>
    /// The stream key for the simulcast destination.
    /// </summary>
    [JsonPropertyName("stream_key")]
    public required string? StreamKey { get; init; }

    /// <summary>
    /// The RTMP URL to stream to.
    /// </summary>
    [JsonPropertyName("stream_url")]
    public required string? StreamUrl { get; init; }

    /// <summary>
    /// The type of the simulcast destination.
    /// <para>
    /// Option descriptions:
    ///  * <c>channel</c> - The destination is a YouTube channel.
    ///  * <c>custom</c> - The destination is custom.
    ///  * <c>organization</c> - The destination is a LinkedIn organization.
    ///  * <c>page</c> - The destination is a Facebook page.
    ///  * <c>profile</c> - The destination is a Facebook or LinkedIn profile.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type19 Type { get; init; }

    /// <summary>
    /// The name of the destination's owner.
    /// </summary>
    [JsonPropertyName("user_display_name")]
    public required string UserDisplayName { get; init; }

    /// <summary>
    /// The ID of the destination's owner.
    /// </summary>
    [JsonPropertyName("user_id")]
    public required double UserId { get; init; }
}

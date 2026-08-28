using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record UsersLiveEventsDestinationsRequest
{
    /// <summary>
    /// The title to display for the simulcast.
    /// </summary>
    [JsonPropertyName("display_name")]
    public required string DisplayName { get; init; }

    /// <summary>
    /// Whether the destination is enabled for simulcasting.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_enabled")]
    public bool? IsEnabled { get; init; }

    /// <summary>
    /// The privacy setting of the destination. Be sure to choose a value that corresponds to your service.
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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privacy")]
    public Privacy9? Privacy { get; init; }

    /// <summary>
    /// The ID of the destination on the specified service, such as the YouTube channel ID or the Facebook page ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provider_destination_id")]
    public string? ProviderDestinationId { get; init; }

    /// <summary>
    /// The ID of the scheduled video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("provider_video_id")]
    public string? ProviderVideoId { get; init; }

    /// <summary>
    /// The time in Unix timestamp format when live streaming is scheduled to start.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("scheduled_at")]
    public double? ScheduledAt { get; init; }

    /// <summary>
    /// The service to simulcast to.
    /// <para>
    /// Option descriptions:
    ///  * <c>custom_rtmp</c> - Simulcast to a custom service.
    ///  * <c>facebook</c> - Simulcast to Facebook Live.
    ///  * <c>linkedin</c> - Simulcast to LinkedIn Live.
    ///  * <c>youtube</c> - Simulcast to YouTube Live.
    /// </para>
    /// </summary>
    [JsonPropertyName("service_name")]
    public required ServiceName1 ServiceName { get; init; }

    /// <summary>
    /// The RTMP stream key.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stream_key")]
    public string? StreamKey { get; init; }

    /// <summary>
    /// The RTMP URL for receiving the video stream.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stream_url")]
    public string? StreamUrl { get; init; }

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

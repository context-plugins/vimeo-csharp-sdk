using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Activity31
{
    /// <summary>
    /// The category associated with the event. This field is present only when the activity type is <c>category</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("category")]
    public Category? Category { get; init; }

    /// <summary>
    /// The channel associated with the event. This field is present only when the activity type is <c>channel</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("channel")]
    public Channel? Channel { get; init; }

    /// <summary>
    /// The video associated with the activity.
    /// </summary>
    [JsonPropertyName("clip")]
    public required Video Clip { get; init; }

    /// <summary>
    /// The group associated with the event. This field is present only when the activity type is <c>group</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("group")]
    public Group? Group { get; init; }

    /// <summary>
    /// Information about the activity's metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata7 Metadata { get; init; }

    /// <summary>
    /// The Vimeo On Demand page associated with the event. This field is present only when the activity type is <c>ondemand</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ondemand_page")]
    public OnDemandPage? OndemandPage { get; init; }

    /// <summary>
    /// The tag associated with the event. This field is present only when the activity type is <c>tag</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("tag")]
    public Tag? Tag { get; init; }

    /// <summary>
    /// The time that the event occurred.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; init; }

    /// <summary>
    /// The activity type.
    /// <para>
    /// Option descriptions:
    ///  * <c>appearance</c> - The activity is an appearance action.
    ///  * <c>category</c> - The activity is a category action.
    ///  * <c>channel</c> - The activity is a channel action.
    ///  * <c>facebook_feed</c> - The activity is a Facebook feed action.
    ///  * <c>group</c> - The activity is a group action.
    ///  * <c>like</c> - The activity is a like action.
    ///  * <c>ondemand</c> - The activity is a Vimeo On Demand action.
    ///  * <c>share</c> - The activity is a share action.
    ///  * <c>tag</c> - The activity is a tag action.
    ///  * <c>twitter_timeline</c> - The activity is a Twitter timeline action.
    ///  * <c>upload</c> - The activity is an upload action.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type10 Type { get; init; }

    /// <summary>
    /// The user associated with the event. This field is present only when the activity type is <c>like</c>, <c>appearance</c>, or <c>share</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("user")]
    public User? User { get; init; }
}

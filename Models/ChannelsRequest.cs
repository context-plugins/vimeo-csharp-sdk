using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record ChannelsRequest
{
    /// <summary>
    /// The description of the channel.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The link to access the channel. You can use a custom name in the URL in place of a numeric channel ID, as in <c>/channels/{url_custom}</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// The name of the channel.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The privacy level of the channel.
    /// <para>
    /// Option descriptions:
    ///  * <c>anybody</c> - Anyone can access the channel.
    ///  * <c>moderators</c> - Only moderators can access the channel.
    ///  * <c>user</c> - Only moderators and designated users can access the channel.
    /// </para>
    /// </summary>
    [JsonPropertyName("privacy")]
    public required Privacy7 Privacy { get; init; }
}

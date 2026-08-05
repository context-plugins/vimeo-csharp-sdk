using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Videos18
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("privacy")]
    public Privacy10? Privacy { get; init; }

    /// <summary>
    /// An array of the user's default content ratings.
    /// <para>
    /// Option descriptions:
    ///  * <c>drugs</c> - The video contains drug or alcohol use.
    ///  * <c>language</c> - The video contains profanity or sexually suggestive content.
    ///  * <c>nudity</c> - The video contains nudity.
    ///  * <c>safe</c> - The video is suitable for all audiences.
    ///  * <c>unrated</c> - The video hasn't been rated.
    ///  * <c>violence</c> - The video contains violent or graphic content.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("rating")]
    public Rating1? Rating { get; init; }
}

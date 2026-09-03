using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record ContentRating
{
    /// <summary>
    /// The reason for the content rating.
    /// <para>
    /// Option descriptions:
    ///  * <c>advertisement</c> - The content contains an advertisement.
    ///  * <c>drugs</c> - The content contains drug or alcohol use.
    ///  * <c>language</c> - The content contains profanity or sexually suggestive language.
    ///  * <c>nudity</c> - The content contains nudity.
    ///  * <c>safe</c> - The content is suitable for all audiences.
    ///  * <c>unrated</c> - The content hasn't been rated.
    ///  * <c>violence</c> - The content contains violence or is graphic.
    /// </para>
    /// </summary>
    [JsonPropertyName("code")]
    public required Code Code { get; init; }

    /// <summary>
    /// The name of the content rating.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The canonical relative URI of the content rating.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string? Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

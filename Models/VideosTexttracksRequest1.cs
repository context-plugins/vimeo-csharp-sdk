using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record VideosTexttracksRequest1
{
    /// <summary>
    /// Whether the current text track is the *active text track,* or the one that appears in the player. Only one text track per language and per type can be active.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The language of the text track. For a full list of supported languages, use the <see href="https://developer.vimeo.com/api/reference/videos#get_languages"><c>/languages?filter=texttracks</c></see> endpoint.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// The name of the text track.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The type of text track.
    /// <para>
    /// Option descriptions:
    ///  * <c>captions</c> - The text track is the captions type.
    ///  * <c>chapters</c> - The text track is the chapters type.
    ///  * <c>descriptions</c> - The text track is the descriptions type.
    ///  * <c>metadata</c> - The text track is the metadata type.
    ///  * <c>subtitles</c> - The text track is the subtitles type.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("type")]
    public Type29? Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

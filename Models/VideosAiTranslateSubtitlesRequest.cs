using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record VideosAiTranslateSubtitlesRequest
{
    /// <summary>
    /// The target language for translation as a language code. Use the <see href="#get_ai_languages"><c>/videos/ai/languages?type=subtitling</c></see> endpoint for a list of supported languages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    /// <summary>
    /// The ID of the text track to use as the translation source. When omitted, the system uses the video's primary transcript. Use <c>GET /videos/{video_id}/texttracks</c> to list available text tracks.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("texttrack_id")]
    public double? TexttrackId { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

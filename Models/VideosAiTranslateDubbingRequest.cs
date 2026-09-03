using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record VideosAiTranslateDubbingRequest
{
    /// <summary>
    /// The accent for the dubbed audio. Each language has its own set of available accents — use the <see href="#get_ai_languages"><c>/videos/ai/languages?type=dubbing</c></see> endpoint to list them. Common values include <c>auto</c> (AI-selected voice) and <c>original</c> (clones the speaker's voice, requires account capability). When omitted for regional variants (e.g. <c>es-MX</c>), the default accent for that variant is used. When omitted for base languages (e.g. <c>es</c>), the service selects automatically.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("accent")]
    public string? Accent { get; init; }

    /// <summary>
    /// The target language for dubbing as a language code. Use the <see href="#get_ai_languages"><c>/videos/ai/languages?type=dubbing</c></see> endpoint for a list of supported languages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

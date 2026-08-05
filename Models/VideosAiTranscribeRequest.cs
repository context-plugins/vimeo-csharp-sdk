using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosAiTranscribeRequest
{
    /// <summary>
    /// The language for transcription as a BCP 47 language code. When omitted, the system auto-detects the spoken language from the video's audio. Use the <see href="#get_ai_languages"><c>/videos/ai/languages?type=transcription</c></see> endpoint for a list of supported languages.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language")]
    public string? Language { get; init; }
}

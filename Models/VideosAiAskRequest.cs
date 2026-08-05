using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosAiAskRequest
{
    /// <summary>
    /// The question to ask about the video content. Maximum 500 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("question")]
    public string? Question { get; init; }
}

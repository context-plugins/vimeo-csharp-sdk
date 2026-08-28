using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record VideosAiAskRequest
{
    /// <summary>
    /// The question to ask about the video content. Maximum 500 characters.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("question")]
    public string? Question { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

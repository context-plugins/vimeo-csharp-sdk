using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about the video's AI content.
/// </summary>
public record AiContent
{
    /// <summary>
    /// Whether the video contains AI-generated audio.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audio")]
    public bool? Audio { get; init; }

    /// <summary>
    /// Whether the video contains AI-generated audio that is marked automatically.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("audio_auto")]
    public bool? AudioAuto { get; init; }

    /// <summary>
    /// Whether the video contains AI-generated visuals.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visual")]
    public bool? Visual { get; init; }

    /// <summary>
    /// Whether the video contains AI-generated visuals that are marked automatically.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("visual_auto")]
    public bool? VisualAuto { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

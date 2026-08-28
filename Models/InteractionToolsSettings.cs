using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The settings for the interaction tools.
/// </summary>
public record InteractionToolsSettings
{
    /// <summary>
    /// Whether anonymous questions are disabled for the interaction tools settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_anonymous_questions_disabled")]
    public bool? IsAnonymousQuestionsDisabled { get; init; }

    /// <summary>
    /// Whether the Q&amp;A is moderated for the interaction tools settings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_qna_moderated")]
    public bool? IsQnaModerated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

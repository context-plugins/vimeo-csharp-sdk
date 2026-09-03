using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record InteractionToolsSetting
{
    /// <summary>
    /// Whether anonymous questions are disabled for the interaction tools settings.
    /// </summary>
    [JsonPropertyName("is_anonymous_questions_disabled")]
    public required bool IsAnonymousQuestionsDisabled { get; init; }

    /// <summary>
    /// Whether the Q&amp;A is moderated for the interaction tools settings.
    /// </summary>
    [JsonPropertyName("is_qna_moderated")]
    public required bool IsQnaModerated { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

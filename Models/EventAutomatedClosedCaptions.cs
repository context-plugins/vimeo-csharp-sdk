using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record EventAutomatedClosedCaptions
{
    /// <summary>
    /// Whether automated closed captions can be enabled.
    /// </summary>
    [JsonPropertyName("auto_cc_can_be_enabled")]
    public required bool AutoCcCanBeEnabled { get; init; }

    /// <summary>
    /// AI credits consumed per minute for auto-captions.
    /// </summary>
    [JsonPropertyName("auto_cc_credits_per_minute")]
    public required double AutoCcCreditsPerMinute { get; init; }

    /// <summary>
    /// Whether the option for automated closed captions is enabled.
    /// </summary>
    [JsonPropertyName("auto_cc_enabled")]
    public required bool AutoCcEnabled { get; init; }

    /// <summary>
    /// Whether automated closed captions are unlimited for the user.
    /// </summary>
    [JsonPropertyName("auto_cc_is_unlimited")]
    public required bool AutoCcIsUnlimited { get; init; }

    /// <summary>
    /// A comma-separated list of keywords for enhancing the speech detection of automated closed captions.
    /// </summary>
    [JsonPropertyName("auto_cc_keywords")]
    public required string AutoCcKeywords { get; init; }

    /// <summary>
    /// The language of the automated closed captions.
    /// </summary>
    [JsonPropertyName("auto_cc_language")]
    public required string? AutoCcLanguage { get; init; }

    /// <summary>
    /// The maximum seconds for automated closed captions (legacy, for users not yet on AI-credit billing).
    /// </summary>
    [JsonPropertyName("auto_cc_limit")]
    public required double? AutoCcLimit { get; init; }

    /// <summary>
    /// The number of seconds remaining for automated closed captions (legacy, for users not yet on AI-credit billing).
    /// </summary>
    [JsonPropertyName("auto_cc_remaining")]
    public required double? AutoCcRemaining { get; init; }

    /// <summary>
    /// AI credits consumed per minute per translation language.
    /// </summary>
    [JsonPropertyName("auto_cc_translation_credits_per_minute")]
    public required double AutoCcTranslationCreditsPerMinute { get; init; }

    /// <summary>
    /// Whether automated caption translations are enabled.
    /// </summary>
    [JsonPropertyName("auto_cc_translation_enabled")]
    public required bool AutoCcTranslationEnabled { get; init; }

    /// <summary>
    /// The list of language codes for caption translations.
    /// </summary>
    [JsonPropertyName("auto_cc_translation_languages")]
    public required IReadOnlyList<string> AutoCcTranslationLanguages { get; init; }

    /// <summary>
    /// The ID of the event.
    /// </summary>
    [JsonPropertyName("event_id")]
    public required double EventId { get; init; }
}

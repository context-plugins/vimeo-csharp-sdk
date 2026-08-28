using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Account dictionary usage and entry limits.
/// </summary>
public record AccountDictionaryQuota
{
    /// <summary>
    /// Glossary term usage and limit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("glossary_terms")]
    public GlossaryTerms? GlossaryTerms { get; init; }

    /// <summary>
    /// Language replacement source-term usage and limit.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("language_replacement_terms")]
    public LanguageReplacementTerms? LanguageReplacementTerms { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

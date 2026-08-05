using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Glossary term usage and limit.
/// </summary>
public record GlossaryTerms
{
    /// <summary>
    /// The maximum number of glossary terms permitted for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public double? Limit { get; init; }

    /// <summary>
    /// The number of active glossary terms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("used")]
    public double? Used { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Language replacement source-term usage and limit.
/// </summary>
public record LanguageReplacementTerms
{
    /// <summary>
    /// The maximum number of language replacement source terms permitted for the account.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("limit")]
    public double? Limit { get; init; }

    /// <summary>
    /// The number of distinct active language replacement source terms.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("used")]
    public double? Used { get; init; }
}

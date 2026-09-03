using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The price map of the promotion formatted for the selected locale.
/// </summary>
public record PriceFormatted1
{
    /// <summary>
    /// The promotional annual price, charged annually.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annual")]
    public string? Annual { get; init; }

    /// <summary>
    /// The promotional monthly price, charged annually.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annual_monthly")]
    public string? AnnualMonthly { get; init; }

    /// <summary>
    /// The promotional monthly price, charged monthly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly")]
    public string? Monthly { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

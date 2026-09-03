using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The price formatted for the selected locale with the associated currency symbol.
/// </summary>
public record PriceFormatted
{
    /// <summary>
    /// The annual price, charged annually.
    /// </summary>
    [JsonPropertyName("annual")]
    public required string Annual { get; init; }

    /// <summary>
    /// The monthly price, charged annually.
    /// </summary>
    [JsonPropertyName("annual_monthly")]
    public required string AnnualMonthly { get; init; }

    /// <summary>
    /// The monthly price, charged monthly.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly")]
    public string? Monthly { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

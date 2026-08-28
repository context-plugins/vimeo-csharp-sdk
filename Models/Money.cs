using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Money
{
    /// <summary>
    /// The amount expressed as a numeral without currency formatting.
    /// </summary>
    [JsonPropertyName("amount")]
    public required double Amount { get; init; }

    /// <summary>
    /// The currency in which the amount is expressed.
    /// </summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>
    /// The amount expressed as a numeral with currency formatting.
    /// </summary>
    [JsonPropertyName("formatted")]
    public required string Formatted { get; init; }

    /// <summary>
    /// The amount expressed as a numeral in the lowest denomination. For example, 12 USD is expressed as 1200.
    /// </summary>
    [JsonPropertyName("unit")]
    public required double Unit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

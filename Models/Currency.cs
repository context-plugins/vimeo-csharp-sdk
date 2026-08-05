using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the currency in which the price of the plan is expressed.
/// </summary>
public record Currency
{
    /// <summary>
    /// The ISO code of the associated currency.
    /// </summary>
    [JsonPropertyName("currency_code")]
    public required string CurrencyCode { get; init; }

    /// <summary>
    /// The symbol of the associated currency.
    /// </summary>
    [JsonPropertyName("symbol")]
    public required string Symbol { get; init; }
}

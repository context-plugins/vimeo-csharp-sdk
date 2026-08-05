using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the plan's promotion.
/// </summary>
public record Promotion
{
    /// <summary>
    /// The promotion code.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// The promotion discount percentage.
    /// </summary>
    [JsonPropertyName("discount")]
    public required double Discount { get; init; }

    /// <summary>
    /// The price map of the promotion.
    /// </summary>
    [JsonPropertyName("price")]
    public required Price1 Price { get; init; }

    /// <summary>
    /// The price map of the promotion formatted for the selected locale.
    /// </summary>
    [JsonPropertyName("price_formatted")]
    public required PriceFormatted1 PriceFormatted { get; init; }

    /// <summary>
    /// Information about the URIs associated with the promotion.
    /// </summary>
    [JsonPropertyName("uri")]
    public required Uri1 Uri { get; init; }
}

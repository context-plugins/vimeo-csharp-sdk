using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Information about the purchased product.
/// </summary>
public record PurchasedProduct
{
    /// <summary>
    /// The display price of the purchased product.
    /// </summary>
    [JsonPropertyName("display_price")]
    public required double DisplayPrice { get; init; }

    /// <summary>
    /// The display price of the purchased product formatted for the selected locale.
    /// </summary>
    [JsonPropertyName("display_price_formatted")]
    public required string DisplayPriceFormatted { get; init; }

    /// <summary>
    /// Whether the purchased product is billed as a monthly subscription.
    /// </summary>
    [JsonPropertyName("is_monthly")]
    public required bool IsMonthly { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

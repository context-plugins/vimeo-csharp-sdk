using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The URLs and entitlements of the associated products in the store.
/// </summary>
public record Metadata25
{
    /// <summary>
    /// The URLs and entitlements of the associated products in the store.
    /// </summary>
    [JsonPropertyName("entitlements")]
    public required Entitlements Entitlements { get; init; }

    [JsonPropertyName("interactions")]
    public required Interactions15 Interactions { get; init; }

    /// <summary>
    /// Whether the product is a bandwidth product.
    /// </summary>
    [JsonPropertyName("is_bandwidth_product")]
    public required bool IsBandwidthProduct { get; init; }

    /// <summary>
    /// Whether the product is a Vimeo payments service product.
    /// </summary>
    [JsonPropertyName("is_ps_plan")]
    public required bool IsPsPlan { get; init; }

    /// <summary>
    /// Information about the purchased product.
    /// </summary>
    [JsonPropertyName("purchased_product")]
    public required PurchasedProduct PurchasedProduct { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The URLs and entitlements of the associated products in the store.
/// </summary>
public record Entitlements
{
    /// <summary>
    /// The entitlement plan ID.
    /// </summary>
    [JsonPropertyName("id")]
    public required double? Id { get; init; }

    /// <summary>
    /// The list of entitlement parameters corresponding to the tier.
    /// </summary>
    [JsonPropertyName("params")]
    public required Params Params { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;

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
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about subscribing to the On Demand page, if subscription is enabled.
/// </summary>
public record Subscription1
{
    /// <summary>
    /// Whether the On Demand product is active.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The link to the On Demand product.
    /// </summary>
    [JsonPropertyName("link")]
    public required string? Link { get; init; }

    /// <summary>
    /// The On Demand product's rental period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("period")]
    public string? Period { get; init; }

    /// <summary>
    /// The accepted currencies and respective pricing for the On Demand product.
    /// </summary>
    [JsonPropertyName("price")]
    public required object Price { get; init; }
}

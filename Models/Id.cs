using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The SKUs of the plans.
/// </summary>
public record Id
{
    /// <summary>
    /// The SKU of the annual plan.
    /// </summary>
    [JsonPropertyName("annual")]
    public required string? Annual { get; init; }

    /// <summary>
    /// The SKU of the monthly plan.
    /// </summary>
    [JsonPropertyName("monthly")]
    public required string? Monthly { get; init; }
}

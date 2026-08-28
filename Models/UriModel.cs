using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The redirect URIs associated with the plan.
/// </summary>
public record UriModel
{
    /// <summary>
    /// The redirect URI for the annual plan in the user's cart.
    /// </summary>
    [JsonPropertyName("annual")]
    public required string? Annual { get; init; }

    /// <summary>
    /// The redirect URI for the free trial in the user's cart.
    /// </summary>
    [JsonPropertyName("free_trial")]
    public required string? FreeTrial { get; init; }

    /// <summary>
    /// The redirect URI for the monthly plan in the user's cart.
    /// </summary>
    [JsonPropertyName("monthly")]
    public required string? Monthly { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

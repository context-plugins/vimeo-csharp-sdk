using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record RegionalDelivery
{
    /// <summary>
    /// The translated display description of the regional delivery permission policy.
    /// </summary>
    [JsonPropertyName("display_description")]
    public required string DisplayDescription { get; init; }

    /// <summary>
    /// The translated display name of the regional delivery permission policy.
    /// </summary>
    [JsonPropertyName("display_name")]
    public required string DisplayName { get; init; }

    /// <summary>
    /// The name of the regional delivery permission policy.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}

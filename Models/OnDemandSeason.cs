using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record OnDemandSeason
{
    /// <summary>
    /// The description of the season.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; init; }

    [JsonPropertyName("metadata")]
    public required Metadata20 Metadata { get; init; }

    /// <summary>
    /// The name of the season.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The position of the season relative to other seasons in the series.
    /// </summary>
    [JsonPropertyName("position")]
    public required double Position { get; init; }

    /// <summary>
    /// The unique identifier of the On Demand season.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// The type of the season.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; init; }

    /// <summary>
    /// The season container's relative URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The creator of the season's On Demand page.
    /// </summary>
    [JsonPropertyName("user")]
    public required User? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

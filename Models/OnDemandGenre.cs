using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record OnDemandGenre
{
    /// <summary>
    /// The canonical name or URL slug of the genre.
    /// </summary>
    [JsonPropertyName("canonical")]
    public required string Canonical { get; init; }

    [JsonPropertyName("interactions")]
    public required Interactions6 Interactions { get; init; }

    /// <summary>
    /// The Vimeo URL for the genre.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    [JsonPropertyName("metadata")]
    public required Metadata8 Metadata { get; init; }

    /// <summary>
    /// The descriptive name of the genre.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The relative URI of the On Demand genre.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

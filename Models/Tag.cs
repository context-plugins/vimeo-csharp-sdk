using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Tag
{
    /// <summary>
    /// The normalized canonical tag name.
    /// </summary>
    [JsonPropertyName("canonical")]
    public required string Canonical { get; init; }

    /// <summary>
    /// Metadata about the tag.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata2 Metadata { get; init; }

    /// <summary>
    /// The tag value.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The tag's resource key string.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// The canonical relative URI of the tag.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The height, width, and source URL properties used to generate the fixed HTML embed code.
/// </summary>
public record EmbedProperties
{
    /// <summary>
    /// The height used to generate the fixed HTML embed code.
    /// </summary>
    [JsonPropertyName("height")]
    public required string Height { get; init; }

    /// <summary>
    /// The source URL used to generate the fixed HTML embed code.
    /// </summary>
    [JsonPropertyName("source_url")]
    public required string SourceUrl { get; init; }

    /// <summary>
    /// The width used to generate the fixed HTML embed code.
    /// </summary>
    [JsonPropertyName("width")]
    public required string Width { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

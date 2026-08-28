using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A collection of information that is connected to this resource.
/// </summary>
public record Connections
{
    /// <summary>
    /// Information about the channels related to this category.
    /// </summary>
    [JsonPropertyName("channels")]
    public required Channels Channels { get; init; }

    /// <summary>
    /// Information about the groups related to this category.
    /// </summary>
    [JsonPropertyName("groups")]
    public required Groups Groups { get; init; }

    /// <summary>
    /// Information about the users related to this category.
    /// </summary>
    [JsonPropertyName("users")]
    public required Users Users { get; init; }

    /// <summary>
    /// Information about the videos related to this category.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

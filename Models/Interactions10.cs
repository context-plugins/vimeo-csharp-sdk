using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A list of resource URIs related to the event.
/// </summary>
public record Interactions10
{
    /// <summary>
    /// Information about where and how to activate the event.
    /// </summary>
    [JsonPropertyName("activate")]
    public required Activate? Activate { get; init; }

    /// <summary>
    /// Information about where and how to delete an item.
    /// </summary>
    [JsonPropertyName("delete")]
    public required Delete3? Delete { get; init; }

    /// <summary>
    /// Information about where and how to edit an item.
    /// </summary>
    [JsonPropertyName("edit")]
    public required Edit3? Edit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

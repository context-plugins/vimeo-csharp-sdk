using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the event destination.
/// </summary>
public record Interactions11
{
    /// <summary>
    /// Information about where and how to edit an item.
    /// </summary>
    [JsonPropertyName("edit")]
    public required Edit3? Edit { get; init; }
}

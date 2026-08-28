using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record NavigationConfig
{
    /// <summary>
    /// Information about showing the search bar in the featured content layout.
    /// </summary>
    [JsonPropertyName("show_search_bar")]
    public required ShowSearchBar ShowSearchBar { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

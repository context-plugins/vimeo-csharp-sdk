using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record NavigationConfig
{
    /// <summary>
    /// Information about showing the search bar in the featured content layout.
    /// </summary>
    [JsonPropertyName("show_search_bar")]
    public required ShowSearchBar ShowSearchBar { get; init; }
}

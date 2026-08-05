using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Subcategory
{
    /// <summary>
    /// The URL to access the subcategory in a browser.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The display name that identifies the subcategory.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The unique identifier to access the subcategory.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

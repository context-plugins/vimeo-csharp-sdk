using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record AncestorPath
{
    /// <summary>
    /// The link to the folder.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The name of the folder.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}

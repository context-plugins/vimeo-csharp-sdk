using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record FolderPermissionPolicy
{
    /// <summary>
    /// The permission policy's name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The permission policy's API URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

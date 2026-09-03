using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record AncestorPath1
{
    /// <summary>
    /// Whether the user can upload to this ancestor folder.
    /// </summary>
    [JsonPropertyName("can_upload")]
    public required bool CanUpload { get; init; }

    /// <summary>
    /// The name of the folder.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The URI of the ancestor folder.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

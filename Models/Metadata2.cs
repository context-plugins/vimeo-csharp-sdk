using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the tag.
/// </summary>
public record Metadata2
{
    /// <summary>
    /// A collection of information that is connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections2 Connections { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information that is connected to this resource.
/// </summary>
public record Connections2
{
    /// <summary>
    /// Information about the videos related to this tag.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos2 Videos { get; init; }
}

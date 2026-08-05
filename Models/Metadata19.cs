using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The video's metadata.
/// </summary>
public record Metadata19
{
    /// <summary>
    /// A list of resource URIs related to the promotion.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections18 Connections { get; init; }
}

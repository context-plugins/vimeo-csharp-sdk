using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the fragments.
/// </summary>
public record Metadata18
{
    /// <summary>
    /// A collection of information that is connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections17 Connections { get; init; }
}

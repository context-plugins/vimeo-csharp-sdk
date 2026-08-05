using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the preset.
/// </summary>
public record Metadata23
{
    /// <summary>
    /// A list of resource URIs related to the preset.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections22 Connections { get; init; }
}

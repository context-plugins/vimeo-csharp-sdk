using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Metadata8
{
    /// <summary>
    /// A collection of information connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections8 Connections { get; init; }
}

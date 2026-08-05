using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Connections19
{
    /// <summary>
    /// The connection to the associated videos.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos12 Videos { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Connections20
{
    /// <summary>
    /// Information about the video's season.
    /// </summary>
    [JsonPropertyName("season")]
    public required Season1 Season { get; init; }
}

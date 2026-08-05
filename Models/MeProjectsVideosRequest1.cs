using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record MeProjectsVideosRequest1
{
    /// <summary>
    /// A comma-separated list of video URIs to add.
    /// </summary>
    [JsonPropertyName("uris")]
    public required string Uris { get; init; }
}

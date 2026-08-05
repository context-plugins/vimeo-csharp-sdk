using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record MeAlbumsVideosRequest
{
    /// <summary>
    /// A comma-separated list of video URIs corresponding to the videos to add.
    /// </summary>
    [JsonPropertyName("videos")]
    public required string Videos { get; init; }
}

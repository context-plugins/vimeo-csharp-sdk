using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record UsersAlbumsVideosRequest
{
    /// <summary>
    /// A comma-separated list of video URIs corresponding to the videos to add.
    /// </summary>
    [JsonPropertyName("videos")]
    public required string Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record UsersProjectsVideosRequest1
{
    /// <summary>
    /// A comma-separated list of video URIs to add.
    /// </summary>
    [JsonPropertyName("uris")]
    public required string Uris { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

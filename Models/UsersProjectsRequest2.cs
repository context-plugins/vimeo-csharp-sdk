using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersProjectsRequest2
{
    /// <summary>
    /// The name of the folder.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}

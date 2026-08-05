using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ChannelsTagsRequest
{
    /// <summary>
    /// The name of the tag to assign.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}

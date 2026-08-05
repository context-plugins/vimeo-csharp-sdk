using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record GroupsRequest
{
    /// <summary>
    /// The description of the group.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The name of the group.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}

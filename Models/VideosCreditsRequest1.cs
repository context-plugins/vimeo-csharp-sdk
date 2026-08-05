using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosCreditsRequest1
{
    /// <summary>
    /// The name of the credited person.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The role of the credited person.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("role")]
    public string? Role { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Add
{
    /// <summary>
    /// The showcase URI to add the video to.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }
}

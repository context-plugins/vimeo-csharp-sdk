using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Remove
{
    /// <summary>
    /// The showcase URI to remove the video from.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }
}

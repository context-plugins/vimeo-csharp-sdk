using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Video5
{
    /// <summary>
    /// The URI of a video to remove.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }
}

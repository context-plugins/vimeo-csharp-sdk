using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Video6
{
    /// <summary>
    /// The URI of a video to add.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("uri")]
    public string? Uri { get; init; }
}

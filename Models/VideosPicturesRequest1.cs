using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record VideosPicturesRequest1
{
    /// <summary>
    /// Whether this thumbnail is the default.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}

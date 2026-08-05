using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record UsersPicturesRequest
{
    /// <summary>
    /// Whether the picture is the authenticated user's active portrait.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}

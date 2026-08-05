using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ReviewPage
{
    /// <summary>
    /// Whether to enable video review.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }
}

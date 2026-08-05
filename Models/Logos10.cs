using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Logos10
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom")]
    public Custom10? Custom { get; init; }

    /// <summary>
    /// Whether to show the Vimeo logo on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vimeo")]
    public bool? Vimeo { get; init; }
}

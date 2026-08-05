using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Logos4
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom")]
    public Custom4? Custom { get; init; }

    /// <summary>
    /// Whether to show the Vimeo logo on the embed player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vimeo")]
    public bool? Vimeo { get; init; }
}

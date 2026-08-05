using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Custom8
{
    /// <summary>
    /// Whether to show the active custom logo on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active")]
    public bool? Active { get; init; }

    /// <summary>
    /// The ID of the custom logo that appears on the embeddable player.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public double? Id { get; init; }

    /// <summary>
    /// The URL that loads when the user clicks the custom logo.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }

    /// <summary>
    /// Whether the custom logo is always visible on the embeddable player (<c>true</c>) or whether the logo appears and disappears with the rest of the UI (<c>false</c>).
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("sticky")]
    public bool? Sticky { get; init; }
}

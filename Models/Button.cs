using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The attributes of the button control.
/// </summary>
public record Button
{
    /// <summary>
    /// The text of the button label.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    /// <summary>
    /// The URL that loads upon clicking the button.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

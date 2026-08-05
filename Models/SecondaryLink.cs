using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The attributes of the secondary link.
/// </summary>
public record SecondaryLink
{
    /// <summary>
    /// The text of the secondary link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    /// <summary>
    /// The URL of the secondary link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link")]
    public string? Link { get; init; }
}

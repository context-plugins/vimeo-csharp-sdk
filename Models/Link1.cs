using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The outro link settings. These fields appear only when <b>type</b> is <c>link</c>.
/// </summary>
public record Link1
{
    /// <summary>
    /// The name of the outro link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("name")]
    public string? Name { get; init; }

    /// <summary>
    /// The URL of the outro link.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("url")]
    public string? Url { get; init; }
}

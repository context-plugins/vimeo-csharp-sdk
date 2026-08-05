using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about purchasing the video.
/// </summary>
public record Buy2
{
    /// <summary>
    /// Whether the video can be purchased.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The purchase price of the video by currency type.
    /// </summary>
    [JsonPropertyName("price")]
    public required object Price { get; init; }

    /// <summary>
    /// Whether the video has been purchased.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchased")]
    public bool? Purchased { get; init; }
}

using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about renting the video.
/// </summary>
public record Rent2
{
    /// <summary>
    /// Whether the video can be rented.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The rental price of the video by currency type.
    /// </summary>
    [JsonPropertyName("price")]
    public required object Price { get; init; }

    /// <summary>
    /// Whether the video has been rented.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("purchased")]
    public bool? Purchased { get; init; }
}

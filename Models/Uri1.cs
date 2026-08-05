using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the URIs associated with the promotion.
/// </summary>
public record Uri1
{
    /// <summary>
    /// The URI of the annual promotion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("annual")]
    public string? Annual { get; init; }

    /// <summary>
    /// The URI of the monthly promotion.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("monthly")]
    public string? Monthly { get; init; }
}

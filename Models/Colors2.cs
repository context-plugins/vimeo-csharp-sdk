using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The first and second colors of the On Demand page.
/// </summary>
public record Colors2
{
    /// <summary>
    /// The hexadecimal color code for the On Demand page's first color.
    /// </summary>
    [JsonPropertyName("primary")]
    public required string Primary { get; init; }

    /// <summary>
    /// The hexadecimal color code for the On Demand page's second color.
    /// </summary>
    [JsonPropertyName("secondary")]
    public required string Secondary { get; init; }
}

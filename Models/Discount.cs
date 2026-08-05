using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the plan discount.
/// </summary>
public record Discount
{
    /// <summary>
    /// The annual discount.
    /// </summary>
    [JsonPropertyName("annual")]
    public required double Annual { get; init; }
}

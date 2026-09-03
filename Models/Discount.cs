using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

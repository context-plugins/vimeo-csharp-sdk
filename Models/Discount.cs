using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

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

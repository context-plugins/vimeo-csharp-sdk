using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A list of resource URIs related to the portfolio.
/// </summary>
public record Connections21
{
    /// <summary>
    /// Information about the videos contained within the portfolio.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos13 Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

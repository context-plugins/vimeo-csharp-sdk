using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The video's Vimeo On Demand information.
/// </summary>
public record Vod
{
    /// <summary>
    /// The video's Vimeo On Demand ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("id")]
    public double? Id { get; init; }

    /// <summary>
    /// The video's Vimeo On Demand link.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

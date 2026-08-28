using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Published
{
    /// <summary>
    /// Whether the On Demand page has been published.
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when this page was published.
    /// </summary>
    [JsonPropertyName("time")]
    public required string Time { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record SegmentLine
{
    /// <summary>
    /// The text from the segment line.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; init; }

    /// <summary>
    /// The speaker of the segment line.
    /// </summary>
    [JsonPropertyName("voice")]
    public required string? Voice { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

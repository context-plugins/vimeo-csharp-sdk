using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Live
{
    /// <summary>
    /// Whether the video was streamed live.
    /// </summary>
    [JsonPropertyName("archived")]
    public required bool Archived { get; init; }

    /// <summary>
    /// Whether the video is currently streaming live.
    /// </summary>
    [JsonPropertyName("streaming")]
    public required bool Streaming { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

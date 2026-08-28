using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Recording
{
    /// <summary>
    /// The duration of the recording, in seconds.
    /// </summary>
    [JsonPropertyName("duration")]
    public required double? Duration { get; init; }

    /// <summary>
    /// The URL to watch the recording.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The recording's thumbnail.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    /// <summary>
    /// When the recording was streamed.
    /// </summary>
    [JsonPropertyName("streamed_on")]
    public required string? StreamedOn { get; init; }

    /// <summary>
    /// The title of the recording. Falls back to the event title when the clip has no explicit name.
    /// </summary>
    [JsonPropertyName("title")]
    public required string? Title { get; init; }

    /// <summary>
    /// The canonical URI of the recording.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

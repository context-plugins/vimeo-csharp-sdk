using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about the authenticated user's interaction to watch the video later.
/// </summary>
public record Watchlater2
{
    /// <summary>
    /// Whether the authenticated user has added the video to their Watch Later queue.
    /// </summary>
    [JsonPropertyName("added")]
    public required bool Added { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the authenticated user added the video to their Watch Later queue.
    /// </summary>
    [JsonPropertyName("added_time")]
    public required string AddedTime { get; init; }

    /// <summary>
    /// The URI for the authenticated user to add the video to their Watch Later queue.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

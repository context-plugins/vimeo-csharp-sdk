using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the authenticated user's interaction to like the video.
/// </summary>
public record Likes3
{
    /// <summary>
    /// Whether the authenticated user has liked the video.
    /// </summary>
    [JsonPropertyName("added")]
    public required bool Added { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the authenticated user liked the video.
    /// </summary>
    [JsonPropertyName("added_time")]
    public required string AddedTime { get; init; }

    /// <summary>
    /// The URI for the authenticated user to like the video.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

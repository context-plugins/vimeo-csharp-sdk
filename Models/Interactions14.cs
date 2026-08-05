using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Interactions14
{
    /// <summary>
    /// Information about the authenticated user's interaction to like the video.
    /// </summary>
    [JsonPropertyName("likes")]
    public required Likes3 Likes { get; init; }

    /// <summary>
    /// Information about the authenticated user's interaction to watch the video later.
    /// </summary>
    [JsonPropertyName("watchlater")]
    public required Watchlater2 Watchlater { get; init; }
}

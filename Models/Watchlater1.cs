using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about whether this video appears on the user's Watch Later list.
/// </summary>
public record Watchlater1
{
    /// <summary>
    /// Whether the user has added the video to their Watch Later list.
    /// </summary>
    [JsonPropertyName("added")]
    public required bool Added { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the user added the video to their Watch Later list.
    /// </summary>
    [JsonPropertyName("added_time")]
    public required string AddedTime { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

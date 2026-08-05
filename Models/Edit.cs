using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about where and how to edit a video.
/// </summary>
public record Edit
{
    /// <summary>
    /// An array of video fields that a user can't interact with.
    /// </summary>
    [JsonPropertyName("blocked_fields")]
    public required IReadOnlyList<string> BlockedFields { get; init; }

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

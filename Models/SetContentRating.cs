using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about setting a content rating for the video.
/// </summary>
public record SetContentRating
{
    /// <summary>
    /// A list of valid content rating flags for the video.
    /// </summary>
    [JsonPropertyName("content_rating")]
    public required IReadOnlyList<string> ContentRating { get; init; }

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

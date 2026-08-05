using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about editing the privacy of the video.
/// </summary>
public record EditPrivacy
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
    /// An array of suggested fields to be used for this interaction.
    /// </summary>
    [JsonPropertyName("properties")]
    public required IReadOnlyList<Properties1> Properties { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

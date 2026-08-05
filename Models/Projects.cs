using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the authenticated user's projects.
/// </summary>
public record Projects
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The total number of projects on this connection.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

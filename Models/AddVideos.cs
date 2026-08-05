using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// An action indicating that the authenticated user is an administrator of the showcase and may therefore add videos. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record AddVideos
{
    /// <summary>
    /// An array of HTTP methods permitted on this URI. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

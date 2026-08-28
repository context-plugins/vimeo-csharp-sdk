using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Information about showcase connections.
/// </summary>
public record Connections11
{
    /// <summary>
    /// Information about the authenticated user's videos that can be added to or removed from this showcase. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("available_videos")]
    public required AvailableVideos AvailableVideos { get; init; }

    /// <summary>
    /// Information about the requested video.
    /// </summary>
    [JsonPropertyName("requested_clip")]
    public required RequestedClip RequestedClip { get; init; }

    /// <summary>
    /// Information about the videos that belong to the showcase.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos9 Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

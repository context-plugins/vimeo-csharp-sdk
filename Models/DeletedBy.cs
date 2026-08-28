using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The user who deleted this video. Null if the video was moved to cold storage automatically.
/// </summary>
public record DeletedBy
{
    /// <summary>
    /// The display name of the user who deleted the video.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The portrait of the user who deleted the video.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    /// <summary>
    /// The URI of the user who deleted the video.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

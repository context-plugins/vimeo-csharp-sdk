using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A collection of information that is connected to this resource.
/// </summary>
public record Connections6
{
    /// <summary>
    /// Information about the requested video.
    /// </summary>
    [JsonPropertyName("requested_clip")]
    public required RequestedClip RequestedClip { get; init; }

    /// <summary>
    /// Information about the members or moderators of the group.
    /// </summary>
    [JsonPropertyName("users")]
    public required Users2 Users { get; init; }

    /// <summary>
    /// Information about the videos contained within the group.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos6 Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

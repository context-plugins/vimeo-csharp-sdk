using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ComposerScenes
{
    /// <summary>
    /// The collection of graphic items, such as lower thirds, polls, and images, associated with this scene.
    /// </summary>
    [JsonPropertyName("graphics")]
    public required IReadOnlyList<Graphic> Graphics { get; init; }

    /// <summary>
    /// The unique identifier of the scene.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// The additional information about the scene.
    /// </summary>
    [JsonPropertyName("meta")]
    public required Meta Meta { get; init; }

    /// <summary>
    /// The name of the scene.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A collection of information relating to custom logos in the embeddable player.
/// </summary>
public record Custom
{
    /// <summary>
    /// Whether the custom logo appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The URL that loads upon clicking the custom logo.
    /// </summary>
    [JsonPropertyName("link")]
    public required string? Link { get; init; }

    /// <summary>
    /// Whether the custom logo appears even when the player interface is hidden.
    /// </summary>
    [JsonPropertyName("sticky")]
    public required bool Sticky { get; init; }

    /// <summary>
    /// The URL of the selected custom logo.
    /// </summary>
    [JsonPropertyName("url")]
    public required string? Url { get; init; }

    /// <summary>
    /// Whether the custom logo should use the URL link.
    /// </summary>
    [JsonPropertyName("use_link")]
    public required bool UseLink { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

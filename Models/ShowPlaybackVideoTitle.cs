using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about showing the video title during playback.
/// </summary>
public record ShowPlaybackVideoTitle
{
    /// <summary>
    /// Whether an upgrade is required to show the video title during playback.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the video title during playback.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

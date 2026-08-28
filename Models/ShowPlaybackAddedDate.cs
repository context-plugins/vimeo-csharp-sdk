using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Information about showing the date when the video was added during playback.
/// </summary>
public record ShowPlaybackAddedDate
{
    /// <summary>
    /// Whether an upgrade is required to show the date when the video was added during playback.
    /// </summary>
    [JsonPropertyName("is_upgrade")]
    public required bool IsUpgrade { get; init; }

    /// <summary>
    /// Whether to show the date when the video was added during playback.
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

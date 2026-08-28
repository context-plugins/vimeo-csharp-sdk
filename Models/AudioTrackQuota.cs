using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The quota parameters for the audio tracks available for this version.
/// </summary>
public record AudioTrackQuota
{
    /// <summary>
    /// The number of audio tracks availible for this version.
    /// </summary>
    [JsonPropertyName("free")]
    public required double Free { get; init; }

    /// <summary>
    /// Whether the current version has reached its maximum quota for audio tracks.
    /// </summary>
    [JsonPropertyName("has_reached_quota")]
    public required bool HasReachedQuota { get; init; }

    /// <summary>
    /// The maximum number of audio tracks that the user can upload per version based on their subscription tier.
    /// </summary>
    [JsonPropertyName("max")]
    public required double Max { get; init; }

    /// <summary>
    /// The number of audio tracks used for this version.
    /// </summary>
    [JsonPropertyName("used")]
    public required double Used { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

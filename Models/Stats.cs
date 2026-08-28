using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A collection of analytics associated with the video.
/// </summary>
public record Stats
{
    /// <summary>
    /// The current total number of times that the video has been played.
    /// </summary>
    [JsonPropertyName("plays")]
    public required double? Plays { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

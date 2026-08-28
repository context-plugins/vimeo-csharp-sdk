using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The additional information about the scene.
/// </summary>
public record Meta
{
    /// <summary>
    /// If the scene is scheduled to play automatically when stream starts.
    /// </summary>
    [JsonPropertyName("is_scheduled")]
    public required bool IsScheduled { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the preset.
/// </summary>
public record Connections22
{
    /// <summary>
    /// Information about the videos in the preset.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos14 Videos { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

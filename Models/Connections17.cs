using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information that is connected to this resource.
/// </summary>
public record Connections17
{
    /// <summary>
    /// Information about the videos that belong to this channel.
    /// </summary>
    [JsonPropertyName("clip")]
    public required Clip Clip { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

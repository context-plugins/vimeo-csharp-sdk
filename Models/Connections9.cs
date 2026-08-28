using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information that is connected to this resource, including videos, genres, and pictures connections.
/// </summary>
public record Connections9
{
    [JsonPropertyName("metadata")]
    public required Metadata10 Metadata { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

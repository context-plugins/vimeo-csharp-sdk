using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The video version's metadata.
/// </summary>
public record Metadata29
{
    [JsonPropertyName("connections")]
    public required Connections27 Connections { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

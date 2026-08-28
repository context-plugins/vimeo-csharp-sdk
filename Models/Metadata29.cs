using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

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

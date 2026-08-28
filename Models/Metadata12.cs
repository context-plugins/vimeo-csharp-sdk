using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Metadata12
{
    [JsonPropertyName("connections")]
    public required Connections12 Connections { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

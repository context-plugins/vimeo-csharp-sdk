using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Metadata10
{
    [JsonPropertyName("connections")]
    public required Connections10 Connections { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

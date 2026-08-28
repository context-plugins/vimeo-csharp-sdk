using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Metadata8
{
    /// <summary>
    /// A collection of information connected to this resource.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections8 Connections { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

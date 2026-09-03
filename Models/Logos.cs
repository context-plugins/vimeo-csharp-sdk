using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information about the logo in the corner of the embeddable player.
/// </summary>
public record Logos
{
    /// <summary>
    /// A collection of information relating to custom logos in the embeddable player.
    /// </summary>
    [JsonPropertyName("custom")]
    public required Custom Custom { get; init; }

    /// <summary>
    /// Whether the Vimeo logo appears in the embeddable player.
    /// </summary>
    [JsonPropertyName("vimeo")]
    public required bool Vimeo { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

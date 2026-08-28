using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// Audio metadata information.
/// </summary>
public record Audio
{
    /// <summary>
    /// The number of audio channels in the source file.
    /// </summary>
    [JsonPropertyName("channels")]
    public required double Channels { get; init; }

    /// <summary>
    /// The raw audio codec of the source file.
    /// </summary>
    [JsonPropertyName("codec")]
    public required string Codec { get; init; }

    /// <summary>
    /// A human-readable version of the audio codec name, such as <c>AAC</c>, <c>MP3</c>, or <c>Opus</c>, or the raw codec value, depending on the codec.
    /// </summary>
    [JsonPropertyName("display_codec")]
    public required string DisplayCodec { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

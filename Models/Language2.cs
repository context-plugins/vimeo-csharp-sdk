using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The language of the audio track.
/// </summary>
public record Language2
{
    /// <summary>
    /// The standard ISO 639-1 code for the language.
    /// </summary>
    [JsonPropertyName("code")]
    public required string Code { get; init; }

    /// <summary>
    /// The name of the language.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }
}

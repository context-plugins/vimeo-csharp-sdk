using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Language
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

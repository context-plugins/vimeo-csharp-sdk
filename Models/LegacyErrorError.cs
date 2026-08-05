using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record LegacyErrorError
{
    /// <summary>
    /// The error message.
    /// </summary>
    [JsonPropertyName("error")]
    public required string Error { get; init; }
}

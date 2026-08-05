using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record AuthError
{
    /// <summary>
    /// The name of the error.
    /// </summary>
    [JsonPropertyName("error")]
    public required string Error { get; init; }

    /// <summary>
    /// The description of the error.
    /// </summary>
    [JsonPropertyName("error_description")]
    public required string ErrorDescription { get; init; }
}

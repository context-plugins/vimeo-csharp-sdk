using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record AuthErrorError
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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the promotion.
/// </summary>
public record Connections18
{
    /// <summary>
    /// Information about the codes associated with the promotion.
    /// </summary>
    [JsonPropertyName("codes")]
    public required Codes Codes { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

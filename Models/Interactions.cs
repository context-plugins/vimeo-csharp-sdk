using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The permissible actions related to the category.
/// </summary>
public record Interactions
{
    /// <summary>
    /// An action indicating if the authenticated user has followed the category.
    /// </summary>
    [JsonPropertyName("follow")]
    public required Follow Follow { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

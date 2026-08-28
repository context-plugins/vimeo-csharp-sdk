using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// An object containing the actions that the user can perform on the comment.
/// </summary>
public record Interactions8
{
    /// <summary>
    /// Metadata for reporting the comment as inappropriate or violating community guidelines.
    /// </summary>
    [JsonPropertyName("report")]
    public required object Report { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

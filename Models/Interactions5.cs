using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// User actions that have involved the group. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record Interactions5
{
    /// <summary>
    /// An action indicating that someone has joined the group. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("join")]
    public required Join Join { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

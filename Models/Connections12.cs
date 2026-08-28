using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Connections12
{
    /// <summary>
    /// The associated video object. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("video")]
    public required Video1 Video { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

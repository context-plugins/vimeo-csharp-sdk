using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Connections12
{
    /// <summary>
    /// The associated video object. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("video")]
    public required Video1 Video { get; init; }
}

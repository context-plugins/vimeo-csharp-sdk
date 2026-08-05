using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the portfolio.
/// </summary>
public record Metadata22
{
    /// <summary>
    /// A list of resource URIs related to the portfolio.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections21 Connections { get; init; }
}

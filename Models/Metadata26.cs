using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The metadata of the team membership.
/// </summary>
public record Metadata26
{
    /// <summary>
    /// A list of resource URIs related to the user.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections24 Connections { get; init; }
}

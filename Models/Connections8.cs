using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A collection of information connected to this resource.
/// </summary>
public record Connections8
{
    /// <summary>
    /// Information about the On Demand pages related to this group.
    /// </summary>
    [JsonPropertyName("pages")]
    public required Pages Pages { get; init; }
}

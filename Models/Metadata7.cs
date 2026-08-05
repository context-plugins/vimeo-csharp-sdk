using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the activity's metadata.
/// </summary>
public record Metadata7
{
    /// <summary>
    /// A list of resource URIs related to the activity.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections7 Connections { get; init; }
}

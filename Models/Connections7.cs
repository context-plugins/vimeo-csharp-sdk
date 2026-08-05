using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the activity.
/// </summary>
public record Connections7
{
    /// <summary>
    /// The activity's related content.
    /// </summary>
    [JsonPropertyName("related")]
    public required Related1? Related { get; init; }
}

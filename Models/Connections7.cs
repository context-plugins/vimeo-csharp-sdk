using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

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

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

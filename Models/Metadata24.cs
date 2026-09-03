using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The item's metadata.
/// </summary>
public record Metadata24
{
    /// <summary>
    /// A list of resource URIs related to the item.
    /// </summary>
    [JsonPropertyName("connections")]
    public required Connections23 Connections { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

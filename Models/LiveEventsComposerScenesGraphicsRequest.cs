using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record LiveEventsComposerScenesGraphicsRequest
{
    /// <summary>
    /// The content of the graphic item.
    /// </summary>
    [JsonPropertyName("item")]
    public required object Item { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

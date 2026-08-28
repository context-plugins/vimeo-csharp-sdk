using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

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

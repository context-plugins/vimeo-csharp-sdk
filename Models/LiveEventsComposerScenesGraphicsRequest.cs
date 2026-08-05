using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record LiveEventsComposerScenesGraphicsRequest
{
    /// <summary>
    /// The content of the graphic item.
    /// </summary>
    [JsonPropertyName("item")]
    public required object Item { get; init; }
}

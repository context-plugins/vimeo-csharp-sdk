using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record MeLiveEventsRequest
{
    /// <summary>
    /// An array of event URIs.
    /// </summary>
    [JsonPropertyName("events")]
    public required IReadOnlyList<string> Events { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record ChannelsCategoriesRequest
{
    /// <summary>
    /// The array of category URIs to add.
    /// </summary>
    [JsonPropertyName("channels")]
    public required IReadOnlyList<string> Channels { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record ChannelsCategoriesRequest
{
    /// <summary>
    /// The array of category URIs to add.
    /// </summary>
    [JsonPropertyName("channels")]
    public required IReadOnlyList<string> Channels { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

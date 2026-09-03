using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Connections27
{
    /// <summary>
    /// Data from the video associated with the version.
    /// </summary>
    [JsonPropertyName("video")]
    public required Video3 Video { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

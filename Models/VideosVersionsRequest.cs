using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record VideosVersionsRequest
{
    /// <summary>
    /// The name of the version.
    /// </summary>
    [JsonPropertyName("file_name")]
    public required string FileName { get; init; }

    [JsonPropertyName("upload")]
    public required Upload4 Upload { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

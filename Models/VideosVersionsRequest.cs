using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

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

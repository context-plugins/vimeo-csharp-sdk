using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Connections26
{
    /// <summary>
    /// Information about the video version that is created from the trim operation.
    /// </summary>
    [JsonPropertyName("created_version")]
    public required CreatedVersion CreatedVersion { get; init; }

    /// <summary>
    /// Information about the video version that is the source of the trimmed video.
    /// </summary>
    [JsonPropertyName("root_version")]
    public required RootVersion RootVersion { get; init; }

    /// <summary>
    /// Information about the video associated with the trim.
    /// </summary>
    [JsonPropertyName("video")]
    public required Video2 Video { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

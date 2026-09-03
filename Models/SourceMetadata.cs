using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// Metadata about the source file.
/// </summary>
public record SourceMetadata
{
    /// <summary>
    /// Audio metadata information.
    /// </summary>
    [JsonPropertyName("audio")]
    public required Audio? Audio { get; init; }

    /// <summary>
    /// A human-readable version of the source video MIME type, such as <c>MP4</c>, <c>WebM</c>, or <c>MOV</c>, or the raw MIME type, depending on the MIME type.
    /// </summary>
    [JsonPropertyName("display_filetype")]
    public required string? DisplayFiletype { get; init; }

    /// <summary>
    /// The MIME type of the source video.
    /// </summary>
    [JsonPropertyName("filetype")]
    public required string? Filetype { get; init; }

    /// <summary>
    /// Video metadata information.
    /// </summary>
    [JsonPropertyName("video")]
    public required Video4? Video { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

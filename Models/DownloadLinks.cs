using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A map of read-only download URLs for the text track, keyed by file format.
/// </summary>
public record DownloadLinks
{
    /// <summary>
    /// The download URL for the SubRip representation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("srt")]
    public string? Srt { get; init; }

    /// <summary>
    /// The download URL for the TTML representation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ttml")]
    public string? Ttml { get; init; }

    /// <summary>
    /// The download URL for the WebVTT representation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vtt")]
    public string? Vtt { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

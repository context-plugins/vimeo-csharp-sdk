using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record Download1
{
    /// <summary>
    /// The time in ISO 8601 format when the audio track link expires.
    /// </summary>
    [JsonPropertyName("expires")]
    public required string Expires { get; init; }

    /// <summary>
    /// The file extension of the audio file.
    /// </summary>
    [JsonPropertyName("extension")]
    public required string Extension { get; init; }

    /// <summary>
    /// The URL of the audio track download.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The rendition of the audio track.
    /// <para>
    /// Option descriptions:
    ///  * <c>source</c> - The audio is the source file.
    /// </para>
    /// </summary>
    [JsonPropertyName("rendition")]
    public string Rendition { get; } = "source";

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

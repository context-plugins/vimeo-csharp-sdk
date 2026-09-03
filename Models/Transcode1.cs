using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The transcode information for the audio track.
/// </summary>
public record Transcode1
{
    /// <summary>
    /// The transcode status of the audio track.
    /// <para>
    /// Option descriptions:
    ///  * <c>complete</c> - Transcoding is complete. The audio track is available.
    ///  * <c>error</c> - There was a transcoding error. The audio track isn't available.
    ///  * <c>in_progress</c> - Transcoding is in progress. The audio track isn't available yet.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status8 Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

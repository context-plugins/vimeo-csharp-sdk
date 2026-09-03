using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about the video's Vimeo Create editing session. This data requires a bearer token with the <c>private</c> scope.
/// </summary>
public record EditSession
{
    /// <summary>
    /// The status of the video's edit session. This data requires a bearer token with the <c>private</c> scope.
    /// <para>
    /// Option descriptions:
    ///  * <c>done</c> - The video is finished processing.
    ///  * <c>failed</c> - Video processing has failed.
    ///  * <c>processing</c> - The video is still being processed.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status19 Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

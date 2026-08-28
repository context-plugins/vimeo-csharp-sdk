using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// The version's transcode information.
/// </summary>
public record Transcode2
{
    /// <summary>
    /// The status code for the availability of the video version.
    /// <para>
    /// Option descriptions:
    ///  * <c>complete</c> - Transcoding is complete. The video version is available.
    ///  * <c>error</c> - There was a transcoding error. The video version isn't available.
    ///  * <c>in_progress</c> - Transcoding is in progress. The video version isn't available yet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status23? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// The transcode information of the video upload.
/// </summary>
public record Transcode
{
    /// <summary>
    /// The video's availability status.
    /// <para>
    /// Option descriptions:
    ///  * <c>complete</c> - Transcoding is complete. The video is available.
    ///  * <c>error</c> - There was a transcoding error. The video isn't available.
    ///  * <c>in_progress</c> - Transcoding is currently underway. The video isn't available yet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public Status6? Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

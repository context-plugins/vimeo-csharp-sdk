using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record VideosChaptersTemporaryPicturesRequest
{
    /// <summary>
    /// The timecode, given in seconds from the start of the video, indicating when the thumbnail should be generated from the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timecode")]
    public double? Timecode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

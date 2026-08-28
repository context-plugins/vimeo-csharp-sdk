using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record MeAlbumsVideosSetAlbumThumbnailRequest
{
    /// <summary>
    /// The time in seconds of the video frame to use as the thumbnail image.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("time_code")]
    public double? TimeCode { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

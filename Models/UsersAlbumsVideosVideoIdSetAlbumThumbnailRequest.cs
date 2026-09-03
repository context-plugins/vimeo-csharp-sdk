using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

public record UsersAlbumsVideosVideoIdSetAlbumThumbnailRequest
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

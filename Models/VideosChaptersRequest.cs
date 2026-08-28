using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record VideosChaptersRequest
{
    /// <summary>
    /// The URI of the chapter's active thumbnail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active_thumbnail_uri")]
    public string? ActiveThumbnailUri { get; init; }

    /// <summary>
    /// An array of URIs of the thumbnails associated with the video chapter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("thumbnail_uris")]
    public IReadOnlyList<string>? ThumbnailUris { get; init; }

    /// <summary>
    /// The timecode of the chapter in seconds from the start of the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("timecode")]
    public double? Timecode { get; init; }

    /// <summary>
    /// The title of the chapter.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("title")]
    public string? Title { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

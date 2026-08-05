using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Chapter
{
    /// <summary>
    /// The URI of the active thumbnail.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("active_thumbnail_uri")]
    public string? ActiveThumbnailUri { get; init; }

    /// <summary>
    /// The thumbnails associated with the video chapter.
    /// </summary>
    [JsonPropertyName("thumbnails")]
    public required IReadOnlyList<Picture> Thumbnails { get; init; }

    /// <summary>
    /// The timecode of the chapter in seconds from the start of the video.
    /// </summary>
    [JsonPropertyName("timecode")]
    public required double Timecode { get; init; }

    /// <summary>
    /// The title of the chapter.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; init; }

    /// <summary>
    /// The relative URI of the chapter.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

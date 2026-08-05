using System.Text.Json.Serialization;

namespace VimeoApi.Models;

public record Size
{
    /// <summary>
    /// The height of the picture in pixels.
    /// </summary>
    [JsonPropertyName("height")]
    public required double Height { get; init; }

    /// <summary>
    /// The direct link to the image file. For information about the format of the image file, see our <see href="https://developer.vimeo.com/api/upload/thumbnails#returning-the-link-to-a-thumbnail">Working with Thumbnail Uploads</see> guide.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The direct link to the image file with a play button overlay. For information about the format of the image file, see our <see href="https://developer.vimeo.com/api/upload/thumbnails#returning-the-link-to-a-thumbnail">Working with Thumbnail Uploads</see> guide.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("link_with_play_button")]
    public string? LinkWithPlayButton { get; init; }

    /// <summary>
    /// The width of the picture in pixels.
    /// </summary>
    [JsonPropertyName("width")]
    public required double Width { get; init; }
}

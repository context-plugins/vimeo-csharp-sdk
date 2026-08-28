using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record AnimatedThumbnail
{
    /// <summary>
    /// The duration of the animated thumbnail in seconds.
    /// </summary>
    [JsonPropertyName("duration")]
    public required double Duration { get; init; }

    /// <summary>
    /// The file format of the animated thumbnail.
    /// </summary>
    [JsonPropertyName("file_format")]
    public required string FileFormat { get; init; }

    /// <summary>
    /// The file size of the animated thumbnail in bytes.
    /// </summary>
    [JsonPropertyName("file_size")]
    public required double FileSize { get; init; }

    /// <summary>
    /// The height of the animated thumbnail in pixels.
    /// </summary>
    [JsonPropertyName("height")]
    public required double Height { get; init; }

    /// <summary>
    /// Whether the animated thumbnail can be downloaded.
    /// </summary>
    [JsonPropertyName("is_downloadable")]
    public required bool IsDownloadable { get; init; }

    /// <summary>
    /// The URL of the animated thumbnail file.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The URL of the animated thumbnail file with a play button overlay.
    /// </summary>
    [JsonPropertyName("link_with_play_button")]
    public required string LinkWithPlayButton { get; init; }

    /// <summary>
    /// The profile ID of the animated thumbnail.
    /// </summary>
    [JsonPropertyName("profile_id")]
    public required string ProfileId { get; init; }

    /// <summary>
    /// The time in the video, in seconds, corresponding to the start of the animation.
    /// </summary>
    [JsonPropertyName("start_time")]
    public required double StartTime { get; init; }

    /// <summary>
    /// The ID of the animated thumbnail.
    /// </summary>
    [JsonPropertyName("uuid")]
    public required string Uuid { get; init; }

    /// <summary>
    /// The width of the animated thumbnail in pixels.
    /// </summary>
    [JsonPropertyName("width")]
    public required double Width { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

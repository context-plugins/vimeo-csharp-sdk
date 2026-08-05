using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Video metadata information.
/// </summary>
public record Video4
{
    /// <summary>
    /// The raw video codec of the source file.
    /// </summary>
    [JsonPropertyName("codec")]
    public required string Codec { get; init; }

    /// <summary>
    /// A human-readable version of the video codec name, such as <c>MP4</c>, <c>WebM</c>, or <c>MOV</c>, or the raw codec value, depending on the codec.
    /// </summary>
    [JsonPropertyName("display_codec")]
    public required string DisplayCodec { get; init; }

    /// <summary>
    /// The frames per second of the source video.
    /// </summary>
    [JsonPropertyName("fps")]
    public required double? Fps { get; init; }

    /// <summary>
    /// The height of the source video in pixels.
    /// </summary>
    [JsonPropertyName("height")]
    public required double Height { get; init; }

    /// <summary>
    /// The spatial projection type of the source video.
    /// </summary>
    [JsonPropertyName("projection")]
    public required string Projection { get; init; }

    /// <summary>
    /// The stereo mode of the source video.
    /// </summary>
    [JsonPropertyName("stereo_mode")]
    public required string StereoMode { get; init; }

    /// <summary>
    /// The width of the source video in pixels.
    /// </summary>
    [JsonPropertyName("width")]
    public required double Width { get; init; }
}

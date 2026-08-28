using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Progressive
{
    /// <summary>
    /// The codec of the video file.
    /// <para>
    /// Option descriptions:
    ///  * <c>AV1</c> - The codec is AV1.
    ///  * <c>H264</c> - The codec is H264.
    ///  * <c>HEVC</c> - The codec is HEVC.
    /// </para>
    /// </summary>
    [JsonPropertyName("codec")]
    public required Codec1? Codec { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video file was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The frames per second of the video.
    /// </summary>
    [JsonPropertyName("fps")]
    public required double Fps { get; init; }

    /// <summary>
    /// The height of the video in pixels.
    /// </summary>
    [JsonPropertyName("height")]
    public required double? Height { get; init; }

    /// <summary>
    /// The direct link to the video file.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the link to the video file expires.
    /// </summary>
    [JsonPropertyName("link_expiration_time")]
    public required string LinkExpirationTime { get; init; }

    /// <summary>
    /// The URLs for logging events.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("log")]
    public object? Log { get; init; }

    /// <summary>
    /// The MD5 hash of the video file.
    /// </summary>
    [JsonPropertyName("md5")]
    public required string Md5 { get; init; }

    /// <summary>
    /// The video rendition.
    /// <para>
    /// Option descriptions:
    ///  * <c>2k</c> - The video has 2K resolution.
    ///  * <c>4k</c> - The video has 4K resolution.
    ///  * <c>5k</c> - The video has 5K resolution.
    ///  * <c>6k</c> - The video has 6K resolution.
    ///  * <c>7k</c> - The video has 7K resolution.
    ///  * <c>8k</c> - The video has 8K resolution.
    ///  * <c>240p</c> - The video has 240p resolution.
    ///  * <c>360p</c> - The video has 360p resolution.
    ///  * <c>480p</c> - The video has 480p resolution.
    ///  * <c>540p</c> - The video has 540p resolution.
    ///  * <c>720p</c> - The video has 720p resolution.
    ///  * <c>1080p</c> - The video has 1080p resolution.
    /// </para>
    /// </summary>
    [JsonPropertyName("rendition")]
    public required Rendition1 Rendition { get; init; }

    /// <summary>
    /// The size in bytes of the video file.
    /// </summary>
    [JsonPropertyName("size")]
    public required double? Size { get; init; }

    /// <summary>
    /// The type of video file.
    /// <para>
    /// Option descriptions:
    ///  * <c>source</c> - The video file is a source file.
    ///  * <c>video/mp4</c> - The video file is in MP4 format.
    ///  * <c>video/webm</c> - The video file is in WebM format.
    ///  * <c>vp6/x-video</c> - The video file is in VP6 format.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type6? Type { get; init; }

    /// <summary>
    /// The width of the video in pixels.
    /// </summary>
    [JsonPropertyName("width")]
    public required double? Width { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

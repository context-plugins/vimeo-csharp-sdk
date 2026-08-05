using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record VideoFile
{
    /// <summary>
    /// The codec of the video file.
    /// <para>
    /// Option descriptions:
    ///  * <c>AV1</c> - The codec is AV1.
    ///  * <c>H264</c> - The codec is H264.
    ///  * <c>HEVC</c> - The codec is HEVC.
    ///  * <c>aac</c> - The audio codec is AAC.
    /// </para>
    /// </summary>
    [JsonPropertyName("codec")]
    public required Codec? Codec { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video file was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video file expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expires")]
    public string? Expires { get; init; }

    /// <summary>
    /// The frames per second of the video. Returns 0 for audio-only files.
    /// </summary>
    [JsonPropertyName("fps")]
    public required double Fps { get; init; }

    /// <summary>
    /// The height of the video in pixels.
    /// </summary>
    [JsonPropertyName("height")]
    public required double Height { get; init; }

    /// <summary>
    /// The direct link to the video file.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("log")]
    public Log? Log { get; init; }

    /// <summary>
    /// The MD5 hash of the video file.
    /// </summary>
    [JsonPropertyName("md5")]
    public required string Md5 { get; init; }

    /// <summary>
    /// The public name of the video file.
    /// </summary>
    [JsonPropertyName("public_name")]
    public required string PublicName { get; init; }

    /// <summary>
    /// The video quality as determined by height and width.
    /// <para>
    /// Option descriptions:
    ///  * <c>audio</c> - The file is audio-only.
    ///  * <c>hd</c> - The video is in high definition.
    ///  * <c>hls</c> - The video is suitable for HTTP live streaming.
    ///  * <c>mobile</c> - The video is mobile quality.
    ///  * <c>sd</c> - The video is in standard definition.
    ///  * <c>source</c> - The video's source file.
    ///  * <c>uhd</c> - The video resolution is 2K or higher.
    /// </para>
    /// </summary>
    [JsonPropertyName("quality")]
    public required Quality Quality { get; init; }

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
    ///  * <c>adaptive</c> - The video rendition is adaptive (for example, HLS or DASH).
    ///  * <c>audio</c> - The file is audio-only.
    ///  * <c>source</c> - The video is the source file.
    /// </para>
    /// </summary>
    [JsonPropertyName("rendition")]
    public required Rendition Rendition { get; init; }

    /// <summary>
    /// The approximate size in bytes of the video file.
    /// </summary>
    [JsonPropertyName("size")]
    public required double Size { get; init; }

    /// <summary>
    /// The converted size of the video file rounded to two decimal places.
    /// </summary>
    [JsonPropertyName("size_short")]
    public required string SizeShort { get; init; }

    /// <summary>
    /// The source link of the video file.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("source_link")]
    public string? SourceLink { get; init; }

    /// <summary>
    /// The type of video file.
    /// <para>
    /// Option descriptions:
    ///  * <c>audio/mp4</c> - The file is an audio-only MPEG-4 container.
    ///  * <c>source</c> - The video file is a source file.
    ///  * <c>video/mp4</c> - The video file is in MP4 format.
    ///  * <c>video/webm</c> - The video file is in WebM format.
    ///  * <c>vp6/x-video</c> - The video file is in VP6 format.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type3? Type { get; init; }

    /// <summary>
    /// The width of the video in pixels.
    /// </summary>
    [JsonPropertyName("width")]
    public required double Width { get; init; }
}

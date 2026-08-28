using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// A collection of the video's badges.
/// </summary>
public record Badges
{
    /// <summary>
    /// Whether the video was filmed using Dolby Vision.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("dolby_vision")]
    public bool? DolbyVision { get; init; }

    /// <summary>
    /// Whether the video has an HDR-compatible transcode.
    /// </summary>
    [JsonPropertyName("hdr")]
    public required bool Hdr { get; init; }

    /// <summary>
    /// Whether the video was filmed using HDR10.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hdr_10")]
    public bool? Hdr10 { get; init; }

    /// <summary>
    /// Whether the video was filmed using HDR10 Plus.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("hdr_10_plus")]
    public bool? Hdr10Plus { get; init; }

    [JsonPropertyName("live")]
    public required Live Live { get; init; }

    /// <summary>
    /// Whether the video has a 4K-quality transcode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ott_4k")]
    public bool? Ott4K { get; init; }

    /// <summary>
    /// Whether the video has 5.1 audio.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ott_5_1_audio")]
    public bool? Ott51Audio { get; init; }

    /// <summary>
    /// Whether the video has an HEVC-compatible transcode.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ott_hevc")]
    public bool? OttHevc { get; init; }

    [JsonPropertyName("staff_pick")]
    public required StaffPick StaffPick { get; init; }

    /// <summary>
    /// Whether the video was filmed using stereo spatial.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("stereo_spatial")]
    public bool? StereoSpatial { get; init; }

    /// <summary>
    /// Whether the video is a Vimeo On Demand video.
    /// </summary>
    [JsonPropertyName("vod")]
    public required bool Vod { get; init; }

    /// <summary>
    /// Whether the video is a Vimeo Weekend Challenge.
    /// </summary>
    [JsonPropertyName("weekend_challenge")]
    public required bool WeekendChallenge { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

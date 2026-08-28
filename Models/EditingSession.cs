using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record EditingSession
{
    /// <summary>
    /// Whether the video has a watermark.
    /// </summary>
    [JsonPropertyName("has_watermark")]
    public required bool HasWatermark { get; init; }

    /// <summary>
    /// Whether the video has been edited by Transcript Video Editing.
    /// </summary>
    [JsonPropertyName("is_edited_by_tve")]
    public required bool IsEditedByTve { get; init; }

    /// <summary>
    /// Whether the current version of the video is at the maximum resolution.
    /// </summary>
    [JsonPropertyName("is_max_resolution")]
    public required bool IsMaxResolution { get; init; }

    /// <summary>
    /// Whether the video has licensed music.
    /// </summary>
    [JsonPropertyName("is_music_licensed")]
    public required bool IsMusicLicensed { get; init; }

    /// <summary>
    /// Whether the video has been rated.
    /// </summary>
    [JsonPropertyName("is_rated")]
    public required bool IsRated { get; init; }

    /// <summary>
    /// The minimum required Vimeo membership for the user to be able to share the video.
    /// </summary>
    [JsonPropertyName("min_tier_for_movie")]
    public required string MinTierForMovie { get; init; }

    /// <summary>
    /// The result video hash for the created video.
    /// </summary>
    [JsonPropertyName("result_video_hash")]
    public required string ResultVideoHash { get; init; }

    /// <summary>
    /// The status of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>done</c> - The video is finished processing.
    ///  * <c>failed</c> - Video processing has failed.
    ///  * <c>processing</c> - The video is still being processed.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status2 Status { get; init; }

    /// <summary>
    /// The version's canonical relative URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("upload_attempt_id_version_uri")]
    public string? UploadAttemptIdVersionUri { get; init; }

    /// <summary>
    /// The version's canonical relative URI.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version_uri")]
    public string? VersionUri { get; init; }

    /// <summary>
    /// The ID of the video's editing session.
    /// </summary>
    [JsonPropertyName("vsid")]
    public required double Vsid { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

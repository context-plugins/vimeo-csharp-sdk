using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record VideoVersion
{
    /// <summary>
    /// Whether the video version is currently active.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// The API app associated with the video version.
    /// </summary>
    [JsonPropertyName("app")]
    public required ApiApp App { get; init; }

    /// <summary>
    /// The quota parameters for the audio tracks available for this version.
    /// </summary>
    [JsonPropertyName("audio_track_quota")]
    public required AudioTrackQuota AudioTrackQuota { get; init; }

    /// <summary>
    /// Whether the version can be restored.
    /// </summary>
    [JsonPropertyName("can_restore_create")]
    public required bool CanRestoreCreate { get; init; }

    /// <summary>
    /// The storyboard ID of the video version.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("create_storyboard_id")]
    public string? CreateStoryboardId { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video version was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// A description of the video version. This description can make use of the full unicode character set. This field appears in the response only when a corresponding value is present.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// The download configuration associated with the version.
    /// </summary>
    [JsonPropertyName("download_config")]
    public required object DownloadConfig { get; init; }

    /// <summary>
    /// The duration in seconds of the video version.
    /// </summary>
    [JsonPropertyName("duration")]
    public required double? Duration { get; init; }

    /// <summary>
    /// Information about the video's Vimeo Create editing session. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("edit_session")]
    public required EditSession EditSession { get; init; }

    /// <summary>
    /// The file name of the video version.
    /// </summary>
    [JsonPropertyName("filename")]
    public required string Filename { get; init; }

    /// <summary>
    /// The size in byes of the video version file.
    /// </summary>
    [JsonPropertyName("filesize")]
    public required double? Filesize { get; init; }

    /// <summary>
    /// Whether the video has interactive capability.
    /// </summary>
    [JsonPropertyName("has_interactive")]
    public required bool HasInteractive { get; init; }

    /// <summary>
    /// The height of the version's video.
    /// </summary>
    [JsonPropertyName("height")]
    public required double? Height { get; init; }

    /// <summary>
    /// Whether the video version has been deleted.
    /// </summary>
    [JsonPropertyName("is_deleted")]
    public required bool IsDeleted { get; init; }

    /// <summary>
    /// Whether the video version is playable.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_playable")]
    public bool? IsPlayable { get; init; }

    /// <summary>
    /// The video version's metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata29 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video version was last modified.
    /// </summary>
    [JsonPropertyName("modified_time")]
    public required string ModifiedTime { get; init; }

    /// <summary>
    /// Whether the video has unified resolution. If the value of this field is <c>false</c>, the video requires transcoding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origin_variable_frame_resolution")]
    public bool? OriginVariableFrameResolution { get; init; }

    /// <summary>
    /// The thumbnail for the video version.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture? Pictures { get; init; }

    /// <summary>
    /// The <c>Play</c> representation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("play")]
    public Play? Play { get; init; }

    /// <summary>
    /// The embed URL for the video's player. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("player_embed_url")]
    public required string PlayerEmbedUrl { get; init; }

    /// <summary>
    /// The sequence number of the video version.
    /// </summary>
    [JsonPropertyName("sequence_number")]
    public required double? SequenceNumber { get; init; }

    /// <summary>
    /// Metadata about the source file.
    /// </summary>
    [JsonPropertyName("source_metadata")]
    public required SourceMetadata? SourceMetadata { get; init; }

    /// <summary>
    /// The version's transcode information.
    /// </summary>
    [JsonPropertyName("transcode")]
    public required Transcode2? Transcode { get; init; }

    /// <summary>
    /// The version's upload information.
    /// </summary>
    [JsonPropertyName("upload")]
    public required Upload1? Upload { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video version was uploaded.
    /// </summary>
    [JsonPropertyName("upload_date")]
    public required string? UploadDate { get; init; }

    /// <summary>
    /// The version's canonical relative URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The owner of the video version.
    /// </summary>
    [JsonPropertyName("user")]
    public required User? User { get; init; }

    /// <summary>
    /// The transcode status code of the video version.
    /// <para>
    /// Option descriptions:
    ///  * <c>complete</c> - Transcoding is complete. The video version is available.
    ///  * <c>error</c> - There was a transcoding error. The video version isn't available.
    ///  * <c>in_progress</c> - Transcoding is in progress. The video version isn't available yet.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("version_transcode_status")]
    public VersionTranscodeStatus1? VersionTranscodeStatus { get; init; }

    /// <summary>
    /// The type of the version.
    /// <para>
    /// Option descriptions:
    ///  * <c>regular</c> - The version was generated through a file upload.
    ///  * <c>screen-recording</c> - The version was generated through Vimeo Record.
    ///  * <c>vimeo-create</c> - The version was generated through Vimeo Create.
    /// </para>
    /// </summary>
    [JsonPropertyName("version_type")]
    public required VersionType VersionType { get; init; }

    /// <summary>
    /// The width of the version's video.
    /// </summary>
    [JsonPropertyName("width")]
    public required double? Width { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

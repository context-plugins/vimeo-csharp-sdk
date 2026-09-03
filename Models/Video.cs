using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record Video
{
    /// <summary>
    /// Whether the video can have multiple review links.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allow_multiple_review_links")]
    public bool? AllowMultipleReviewLinks { get; init; }

    /// <summary>
    /// An array of privacy settings supported for this video and the requesting user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("allowed_privacies")]
    public IReadOnlyList<string>? AllowedPrivacies { get; init; }

    /// <summary>
    /// The API application associated with the video owner's token.
    /// </summary>
    [JsonPropertyName("app")]
    public required ApiApp App { get; init; }

    /// <summary>
    /// Whether the video can be moved to a folder. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("can_move_to_project")]
    public required bool CanMoveToProject { get; init; }

    /// <summary>
    /// The categories that the video belongs to.
    /// </summary>
    [JsonPropertyName("categories")]
    public required IReadOnlyList<Category> Categories { get; init; }

    /// <summary>
    /// The video's granular content rating.
    /// <para>
    /// Option descriptions:
    ///  * <c>advertisement</c> - The video contains advertisements.
    ///  * <c>drugs</c> - The video contains drug or alcohol use.
    ///  * <c>language</c> - The video contains profanity or sexually suggestive content.
    ///  * <c>nudity</c> - The video contains nudity.
    ///  * <c>safe</c> - The video is safe for all audiences.
    ///  * <c>unrated</c> - The video hasn't been rated.
    ///  * <c>violence</c> - The video contains violence.
    /// </para>
    /// </summary>
    [JsonPropertyName("content_rating")]
    public required ContentRating4 ContentRating { get; init; }

    /// <summary>
    /// The video's high-level content rating class.
    /// <para>
    /// Option descriptions:
    ///  * <c>explicit</c> - The video contains one or more explicit content rating types.
    ///  * <c>safe</c> - The video contains no explicit content rating types.
    ///  * <c>unrated</c> - The video doesn't belong to a content rating class.
    /// </para>
    /// </summary>
    [JsonPropertyName("content_rating_class")]
    public required ContentRatingClass ContentRatingClass { get; init; }

    /// <summary>
    /// The context of the video's subscription, if the video is part of a subscription.
    /// </summary>
    [JsonPropertyName("context")]
    public required Context Context { get; init; }

    /// <summary>
    /// Whether this video counts toward the owner's managed (restricted) storage limit — i.e. it is non-public OR embeddable. Only rendered for owners that actually have a managed storage cap (repackaged / REPACK_FREE plans); omitted otherwise, since the two-pool model does not apply. Clients use this to mark managed-storage videos and to offer the "make it public &amp; non-embeddable to free managed storage / unfreeze" affordance.
    /// </summary>
    [JsonPropertyName("counts_toward_managed_storage")]
    public required bool CountsTowardManagedStorage { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The video's custom metadata fields with their settings and current values.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("custom_metadata")]
    public IReadOnlyList<CustomMetadatum>? CustomMetadata { get; init; }

    /// <summary>
    /// The custom URL of the video.
    /// </summary>
    [JsonPropertyName("custom_url")]
    public required string? CustomUrl { get; init; }

    /// <summary>
    /// The user who deleted this video. Null if the video was moved to cold storage automatically.
    /// </summary>
    [JsonPropertyName("deleted_by")]
    public required DeletedBy? DeletedBy { get; init; }

    /// <summary>
    /// A brief explanation of the video's content.
    /// </summary>
    [JsonPropertyName("description")]
    public required string? Description { get; init; }

    /// <summary>
    /// A brief explanation of the video's content, formatted with HTML entities.
    /// </summary>
    [JsonPropertyName("description_html")]
    public required string DescriptionHtml { get; init; }

    /// <summary>
    /// A JSON representation of the description.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("description_rich")]
    public string? DescriptionRich { get; init; }

    /// <summary>
    /// The list of downloadable files for the video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("download")]
    public IReadOnlyList<VideoFile>? Download { get; init; }

    /// <summary>
    /// The video's duration in seconds. A value of <c>0</c> indicates the duration hasn't been calculated yet.
    /// </summary>
    [JsonPropertyName("duration")]
    public required double Duration { get; init; }

    /// <summary>
    /// Information about the video's Vimeo Create editing session. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("edit_session")]
    public EditingSession? EditSession { get; init; }

    /// <summary>
    /// Information about embedding the video.
    /// </summary>
    [JsonPropertyName("embed")]
    public required EmbedSettings Embed { get; init; }

    /// <summary>
    /// The explicit access summary of the video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("explicit_access_summary")]
    public ExplicitAccessSummary? ExplicitAccessSummary { get; init; }

    /// <summary>
    /// The list of files for the video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("files")]
    public IReadOnlyList<VideoFile>? Files { get; init; }

    /// <summary>
    /// The total combined file size for all versions of the video, and the file size type.
    /// </summary>
    [JsonPropertyName("files_size")]
    public required VideoVersionsSize FilesSize { get; init; }

    /// <summary>
    /// Whether the video has audio.
    /// </summary>
    [JsonPropertyName("has_audio")]
    public required bool HasAudio { get; init; }

    /// <summary>
    /// Whether the video has alternate audio tracks.
    /// </summary>
    [JsonPropertyName("has_audio_tracks")]
    public required bool HasAudioTracks { get; init; }

    /// <summary>
    /// Whether the video has chapters.
    /// </summary>
    [JsonPropertyName("has_chapters")]
    public required bool HasChapters { get; init; }

    /// <summary>
    /// Whether the video has interactive capability.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_interactive")]
    public bool? HasInteractive { get; init; }

    /// <summary>
    /// Whether the video has text tracks.
    /// </summary>
    [JsonPropertyName("has_text_tracks")]
    public required bool HasTextTracks { get; init; }

    /// <summary>
    /// The video's height in pixels.
    /// </summary>
    [JsonPropertyName("height")]
    public required double Height { get; init; }

    /// <summary>
    /// Whether the video's privacy is being suppressed to private because the owner's current plan no longer supports its original privacy setting (for example, a previously unlisted video on a downgraded/free account). The video's stored privacy is preserved as the owner's intent and served back automatically if the owner upgrades again. Distinct from <c>is_cold_storage</c>, which covers videos frozen for exceeding the plan's storage limit.
    /// </summary>
    [JsonPropertyName("is_cold_privacy_restricted")]
    public required bool IsColdPrivacyRestricted { get; init; }

    /// <summary>
    /// Whether the video has been moved to cold storage.
    /// </summary>
    [JsonPropertyName("is_cold_storage")]
    public required bool IsColdStorage { get; init; }

    /// <summary>
    /// Whether the video is privacy restricted due to a copyright infringement. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("is_copyright_restricted")]
    public required bool IsCopyrightRestricted { get; init; }

    /// <summary>
    /// Whether the video is a free Vimeo Stock video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_free")]
    public bool? IsFree { get; init; }

    /// <summary>
    /// Whether the video is playable.
    /// </summary>
    [JsonPropertyName("is_playable")]
    public required bool IsPlayable { get; init; }

    /// <summary>
    /// Whether the current user has starred this video.
    /// </summary>
    [JsonPropertyName("is_starred_by_cur_user")]
    public required bool IsStarredByCurUser { get; init; }

    /// <summary>
    /// The video's primary language.
    /// </summary>
    [JsonPropertyName("language")]
    public required string? Language { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the user last modified the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_user_action_event_date")]
    public string? LastUserActionEventDate { get; init; }

    /// <summary>
    /// The <see href="http://creativecommons.org/licenses/">Creative Commons</see> license that the video is given under.
    /// <para>
    /// Option descriptions:
    ///  * `` - No Creative Commons license has been set for the video.
    ///  * <c>by</c> - The video is given under the Attribution license.
    ///  * <c>by-nc</c> - The video is given under the Attribution Non-Commercial license.
    ///  * <c>by-nc-nd</c> - The video is given under the Attribution Non-Commercial No Derivatives license.
    ///  * <c>by-nc-sa</c> - The video is given under the Attribution Non-Commercial Share Alike license.
    ///  * <c>by-nd</c> - The video is given under the Attribution No Derivatives license.
    ///  * <c>by-sa</c> - The video is given under the Attribution Share Alike license.
    ///  * <c>cc0</c> - The video is given under the Public Domain Dedication license.
    /// </para>
    /// </summary>
    [JsonPropertyName("license")]
    public required License1 License { get; init; }

    /// <summary>
    /// The link to the video.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The link to the video management page. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("manage_link")]
    public string? ManageLink { get; init; }

    /// <summary>
    /// The video's metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata4 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video metadata was last modified.
    /// </summary>
    [JsonPropertyName("modified_time")]
    public required string ModifiedTime { get; init; }

    /// <summary>
    /// The video's title.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Whether the video has unified resolution. If the value of this field is <c>false</c>, the video requires transcoding.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("origin_variable_frame_resolution")]
    public bool? OriginVariableFrameResolution { get; init; }

    /// <summary>
    /// Information about the video's page settings. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("page")]
    public VideoPageSettings? Page { get; init; }

    /// <summary>
    /// Information about the project that contains the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("parent_project")]
    public Project? ParentProject { get; init; }

    /// <summary>
    /// The privacy-enabled password to watch the video. Only the video's owner and team members with permission can access the video's password. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("password")]
    public string? Password { get; init; }

    /// <summary>
    /// The video's active picture.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Picture Pictures { get; init; }

    /// <summary>
    /// The <c>Play</c> representation.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("play")]
    public Play? Play { get; init; }

    /// <summary>
    /// The video's player embed URL.
    /// </summary>
    [JsonPropertyName("player_embed_url")]
    public required string PlayerEmbedUrl { get; init; }

    /// <summary>
    /// The video's privacy setting.
    /// </summary>
    [JsonPropertyName("privacy")]
    public required Privacy3 Privacy { get; init; }

    /// <summary>
    /// Whether the video's content rating is locked by a moderator.
    /// </summary>
    [JsonPropertyName("rating_mod_locked")]
    public required bool RatingModLocked { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the video was released.
    /// </summary>
    [JsonPropertyName("release_time")]
    public required string ReleaseTime { get; init; }

    /// <summary>
    /// The resource key string of the video.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// All active review links associated with the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_links")]
    public IReadOnlyList<ReviewLink>? ReviewLinks { get; init; }

    /// <summary>
    /// The review status of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>approved</c> - The video review was approved.
    ///  * <c>in_progress</c> - The video review is in progress.
    ///  * <c>needs_review</c> - The video needs to be reviewed.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_status")]
    public ReviewStatus? ReviewStatus { get; init; }

    /// <summary>
    /// Whether to show the button for reviews on single video view recipient pages. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("show_review_page")]
    public required bool ShowReviewPage { get; init; }

    /// <summary>
    /// Whether to show the single video view footer banner on recipient pages. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("show_svv_footer_banner")]
    public required bool ShowSvvFooterBanner { get; init; }

    /// <summary>
    /// Whether to enable timecoded comments on the single video view recipient page. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("show_svv_timecoded_comments")]
    public required bool ShowSvvTimecodedComments { get; init; }

    /// <summary>
    /// The video's 360 spatial data.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("spatial")]
    public Spatial? Spatial { get; init; }

    /// <summary>
    /// A collection of analytics associated with the video.
    /// </summary>
    [JsonPropertyName("stats")]
    public required Stats Stats { get; init; }

    /// <summary>
    /// The status code for the availability of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>available</c> - The video is available.
    ///  * <c>failed</c> - There was an error in rendering the video.
    ///  * <c>processing</c> - Rendering has started and is currently underway for the video.
    ///  * <c>quota_exceeded</c> - The user's weekly upload quota is exceeded with this video.
    ///  * <c>total_cap_exceeded</c> - The user's total storage limit is exceeded with this video.
    ///  * <c>transcode_starting</c> - Transcoding is starting for the video.
    ///  * <c>transcoding</c> - Transcoding has started and is currently underway for the video.
    ///  * <c>transcoding_error</c> - There was an error in transcoding the video.
    ///  * <c>unavailable</c> - The video is unavailable.
    ///  * <c>uploading</c> - The video is being uploaded.
    ///  * <c>uploading_error</c> - There was an error in uploading the video.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status4 Status { get; init; }

    /// <summary>
    /// An array of all tags assigned to the video.
    /// </summary>
    [JsonPropertyName("tags")]
    public required IReadOnlyList<Tag> Tags { get; init; }

    /// <summary>
    /// The transcode information of the video upload.
    /// </summary>
    [JsonPropertyName("transcode")]
    public required Transcode? Transcode { get; init; }

    /// <summary>
    /// The transcript information of the video. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("transcript")]
    public required Transcript Transcript { get; init; }

    /// <summary>
    /// The type of the video.
    /// <para>
    /// Option descriptions:
    ///  * <c>live</c> - The video is or was an event.
    ///  * <c>stock</c> - The video is a Vimeo Stock video.
    ///  * <c>video</c> - The video is a standard Vimeo video.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type7 Type { get; init; }

    /// <summary>
    /// The video's upload information.
    /// </summary>
    [JsonPropertyName("upload")]
    public required Upload? Upload { get; init; }

    /// <summary>
    /// The video's uploader.
    /// </summary>
    [JsonPropertyName("uploader")]
    public required Uploader Uploader { get; init; }

    /// <summary>
    /// The video's canonical relative URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The video's owner.
    /// </summary>
    [JsonPropertyName("user")]
    public required User User { get; init; }

    /// <summary>
    /// Whether the video uses digital rights management.
    /// </summary>
    [JsonPropertyName("uses_drm")]
    public required bool UsesDrm { get; init; }

    /// <summary>
    /// Detailed transcode status information for the current version of the video upload.
    /// </summary>
    [JsonPropertyName("version_transcode_status")]
    public required VersionTranscodeStatus VersionTranscodeStatus { get; init; }

    /// <summary>
    /// The video's Vimeo On Demand information.
    /// </summary>
    [JsonPropertyName("vod")]
    public required Vod Vod { get; init; }

    /// <summary>
    /// The video's width in pixels.
    /// </summary>
    [JsonPropertyName("width")]
    public required double Width { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

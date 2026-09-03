using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the video.
/// </summary>
public record Interactions3
{
    /// <summary>
    /// Information about adding or removing a video from the showcase. This information is included only when the video is referenced by the URI of a showcase that's moderated by the user.
    /// </summary>
    [JsonPropertyName("album")]
    public required Album4? Album { get; init; }

    /// <summary>
    /// Information about where and how to submit questions to the AI service for this video.
    /// </summary>
    [JsonPropertyName("ask_ai")]
    public required AskAi AskAi { get; init; }

    /// <summary>
    /// Information about where and how to submit questions by managers to the AI service for this video.
    /// </summary>
    [JsonPropertyName("ask_ai_manager")]
    public required AskAiManager AskAiManager { get; init; }

    /// <summary>
    /// Information about where and how to submit questions by viewers to the AI service for this video.
    /// </summary>
    [JsonPropertyName("ask_ai_viewer")]
    public required AskAiViewer AskAiViewer { get; init; }

    /// <summary>
    /// The Buy interaction for the On Demand video.
    /// </summary>
    [JsonPropertyName("buy")]
    public required Buy? Buy { get; init; }

    /// <summary>
    /// Whether the current user can comment on the video on the video management page.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("can_comment")]
    public bool? CanComment { get; init; }

    /// <summary>
    /// Whether the current user can add reactions to collaborator comments.
    /// </summary>
    [JsonPropertyName("can_react_to_collab_comments")]
    public required bool CanReactToCollabComments { get; init; }

    /// <summary>
    /// Information about whether the user can request a team upgrade from the Viewer role.
    /// </summary>
    [JsonPropertyName("can_request_team_role_upgrade")]
    public required CanRequestTeamRoleUpgrade CanRequestTeamRoleUpgrade { get; init; }

    /// <summary>
    /// Whether a user can update the video privacy to public.
    /// </summary>
    [JsonPropertyName("can_update_privacy_to_public")]
    public required CanUpdatePrivacyToPublic CanUpdatePrivacyToPublic { get; init; }

    /// <summary>
    /// Information about removing a video from the channel. This information is included only when the video is referenced by the URI of a channel that's moderated by the user.
    /// </summary>
    [JsonPropertyName("channel")]
    public required Channel1 Channel { get; init; }

    /// <summary>
    /// Information about where and how to edit a video using the Vimeo Create editor.
    /// </summary>
    [JsonPropertyName("create_editor")]
    public required CreateEditor CreateEditor { get; init; }

    /// <summary>
    /// Information about where and how to delete a video.
    /// </summary>
    [JsonPropertyName("delete")]
    public required Delete Delete { get; init; }

    /// <summary>
    /// Information about where and how to edit a video.
    /// </summary>
    [JsonPropertyName("edit")]
    public required Edit Edit { get; init; }

    /// <summary>
    /// Information about editing the privacy of the video.
    /// </summary>
    [JsonPropertyName("edit_privacy")]
    public required EditPrivacy EditPrivacy { get; init; }

    /// <summary>
    /// Whether the current user can report the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("flag_clip")]
    public bool? FlagClip { get; init; }

    /// <summary>
    /// Information about whether the video has restricted privacy options.
    /// </summary>
    [JsonPropertyName("has_restricted_privacy_options")]
    public required HasRestrictedPrivacyOptions HasRestrictedPrivacyOptions { get; init; }

    /// <summary>
    /// Information about where and how to create a highlight for the video.
    /// </summary>
    [JsonPropertyName("highlights")]
    public required Highlights Highlights { get; init; }

    /// <summary>
    /// Whether the user can interact with the video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("interact")]
    public bool? Interact { get; init; }

    /// <summary>
    /// Information about where and how to get a list of team members
    /// or groups who were explicitly invited to a video, and where and how to invite a team member to a video.
    /// </summary>
    [JsonPropertyName("invite")]
    public required Invite Invite { get; init; }

    /// <summary>
    /// The associated legal hold object.
    /// </summary>
    [JsonPropertyName("legal_hold")]
    public required LegalHold LegalHold { get; init; }

    /// <summary>
    /// Information about whether the user has liked this video.
    /// </summary>
    [JsonPropertyName("like")]
    public required Like Like { get; init; }

    /// <summary>
    /// Information about whether the video owner has LMS export enabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lms_export")]
    public object? LmsExport { get; init; }

    /// <summary>
    /// The Rent interaction for the On Demand video.
    /// </summary>
    [JsonPropertyName("rent")]
    public required Rent? Rent { get; init; }

    /// <summary>
    /// Information about where and how to report a video.
    /// </summary>
    [JsonPropertyName("report")]
    public required Report1 Report { get; init; }

    /// <summary>
    /// Information about setting a content rating for the video.
    /// </summary>
    [JsonPropertyName("set_content_rating")]
    public required SetContentRating SetContentRating { get; init; }

    /// <summary>
    /// Subscription information for an On Demand video.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("subscribe")]
    public Subscribe? Subscribe { get; init; }

    /// <summary>
    /// Information about whether the current user can create or get a summary for the video.
    /// </summary>
    [JsonPropertyName("summary")]
    public required Summary Summary { get; init; }

    /// <summary>
    /// Information about where and how to create a text translation for the video.
    /// </summary>
    [JsonPropertyName("text_translations")]
    public required TextTranslations TextTranslations { get; init; }

    /// <summary>
    /// Information about where and how to edit a video using the Transcription-based Video Editor editor.
    /// </summary>
    [JsonPropertyName("transcript_video_editor")]
    public required TranscriptVideoEditor TranscriptVideoEditor { get; init; }

    /// <summary>
    /// Information about where and how to create a translation for the video.
    /// </summary>
    [JsonPropertyName("translations")]
    public required Translations Translations { get; init; }

    /// <summary>
    /// Information about where and how to trim the video.
    /// </summary>
    [JsonPropertyName("trim")]
    public required Trim Trim { get; init; }

    /// <summary>
    /// Information about where and how to validate a video field.
    /// </summary>
    [JsonPropertyName("validate")]
    public required Validate Validate { get; init; }

    /// <summary>
    /// Information about whether a user has permissions to view the privacy of the video.
    /// </summary>
    [JsonPropertyName("view_privacy")]
    public required ViewPrivacy ViewPrivacy { get; init; }

    /// <summary>
    /// Information about whether a user can view the team members associated with a video.
    /// </summary>
    [JsonPropertyName("view_team_members")]
    public required ViewTeamMembers ViewTeamMembers { get; init; }

    /// <summary>
    /// Information about removing this video from the user's list of watched videos.
    /// </summary>
    [JsonPropertyName("watched")]
    public required Watched Watched { get; init; }

    /// <summary>
    /// Information about whether this video appears on the user's Watch Later list.
    /// </summary>
    [JsonPropertyName("watchlater")]
    public required Watchlater1 Watchlater { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

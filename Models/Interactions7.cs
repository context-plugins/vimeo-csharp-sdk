using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the showcase.
/// </summary>
public record Interactions7
{
    /// <summary>
    /// An action indicating that the authenticated user is an administrator of the showcase and may therefore add custom thumbnails. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("add_custom_thumbnails")]
    public required AddCustomThumbnails AddCustomThumbnails { get; init; }

    /// <summary>
    /// An action indicating that the authenticated user is an administrator of the showcase and may therefore add events. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("add_live_events")]
    public required AddLiveEvents AddLiveEvents { get; init; }

    /// <summary>
    /// An action indicating that the authenticated user is an administrator of the showcase and may therefore add custom logos. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("add_logos")]
    public required AddLogos AddLogos { get; init; }

    /// <summary>
    /// Information about adding or removing a video from the showcase. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("add_to")]
    public required AddTo1? AddTo { get; init; }

    /// <summary>
    /// An action indicating that the authenticated user is an administrator of the showcase and may therefore add videos. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("add_videos")]
    public required AddVideos AddVideos { get; init; }

    /// <summary>
    /// Whether the user can update the showcase privacy to public.
    /// </summary>
    [JsonPropertyName("can_update_privacy_to_public")]
    public required CanUpdatePrivacyToPublic1 CanUpdatePrivacyToPublic { get; init; }

    /// <summary>
    /// Information about where and how to delete a showcase.
    /// </summary>
    [JsonPropertyName("delete")]
    public required Delete2? Delete { get; init; }

    /// <summary>
    /// Information about where and how to edit a showcase.
    /// </summary>
    [JsonPropertyName("edit")]
    public required Edit2? Edit { get; init; }

    /// <summary>
    /// An action indicating that the authenticated user can edit event videos inside the showcase. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("edit_live_events")]
    public required EditLiveEvents EditLiveEvents { get; init; }

    /// <summary>
    /// Information about where and how to invite a team member to a showcase.
    /// </summary>
    [JsonPropertyName("invite")]
    public required Invite3? Invite { get; init; }

    /// <summary>
    /// Information about whether a user has permissions to view the privacy of the showcase.
    /// </summary>
    [JsonPropertyName("view_privacy")]
    public required ViewPrivacy1? ViewPrivacy { get; init; }
}

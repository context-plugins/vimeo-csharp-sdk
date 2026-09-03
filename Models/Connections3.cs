using System.Text.Json.Serialization;
using VimeoApi.Core.Models;

namespace VimeoApi.Models;

/// <summary>
/// The list of resource URIs related to the authenticated user.
/// </summary>
public record Connections3
{
    /// <summary>
    /// Information about the showcases created by the authenticated user.
    /// </summary>
    [JsonPropertyName("albums")]
    public required Albums Albums { get; init; }

    /// <summary>
    /// Information about the appearances of the authenticated user in other videos.
    /// </summary>
    [JsonPropertyName("appearances")]
    public required Appearances Appearances { get; init; }

    /// <summary>
    /// Information about the users who have been blocked by the authenticated user. This data requires a bearer token with the <c>private</c> scope. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("block")]
    public Block? Block { get; init; }

    /// <summary>
    /// Information about the categories that the authenticated user is following.
    /// </summary>
    [JsonPropertyName("categories")]
    public required Categories Categories { get; init; }

    /// <summary>
    /// Information about the channels to which the authenticated user subscribes.
    /// </summary>
    [JsonPropertyName("channels")]
    public required Channels1 Channels { get; init; }

    /// <summary>
    /// Information about the authenticated user's connected apps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("connected_apps")]
    public ConnectedApps? ConnectedApps { get; init; }

    /// <summary>
    /// Information about the authenticated user's feed.
    /// </summary>
    [JsonPropertyName("feed")]
    public required Feed Feed { get; init; }

    /// <summary>
    /// Information about the authenticated user's root level folders and videos.
    /// </summary>
    [JsonPropertyName("folders_root")]
    public required FoldersRoot FoldersRoot { get; init; }

    /// <summary>
    /// Information about the authenticated user's followers.
    /// </summary>
    [JsonPropertyName("followers")]
    public required Followers Followers { get; init; }

    /// <summary>
    /// Information about the users who are followed by the authenticated user.
    /// </summary>
    [JsonPropertyName("following")]
    public required Following Following { get; init; }

    /// <summary>
    /// Information about the groups created by the authenticated user.
    /// </summary>
    [JsonPropertyName("groups")]
    public required Groups1 Groups { get; init; }

    /// <summary>
    /// Information about the authenticated user's auto upload apps.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("import_apps")]
    public ImportApps? ImportApps { get; init; }

    /// <summary>
    /// Information about the authenticated user's lead capture form. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("lead_capture_form")]
    public LeadCaptureForm? LeadCaptureForm { get; init; }

    /// <summary>
    /// Information about the videos that the authenticated user has liked.
    /// </summary>
    [JsonPropertyName("likes")]
    public required Likes Likes { get; init; }

    /// <summary>
    /// Information about the channels that the authenticated user moderates.
    /// </summary>
    [JsonPropertyName("moderated_channels")]
    public required ModeratedChannels ModeratedChannels { get; init; }

    /// <summary>
    /// Information about the upload folder for Microsoft Teams recordings.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ms_teams_team_folder_id")]
    public MsTeamsTeamFolderId? MsTeamsTeamFolderId { get; init; }

    /// <summary>
    /// Information about the Microsoft Teams tenant token ID.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("ms_teams_tenant_token_id")]
    public string? MsTeamsTenantTokenId { get; init; }

    /// <summary>
    /// Information about the authenticated user's portraits.
    /// </summary>
    [JsonPropertyName("pictures")]
    public required Pictures Pictures { get; init; }

    /// <summary>
    /// Information about the authenticated user's portfolios.
    /// </summary>
    [JsonPropertyName("portfolios")]
    public required Portfolios Portfolios { get; init; }

    /// <summary>
    /// Information about the authenticated user's projects.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("projects")]
    public Projects? Projects { get; init; }

    /// <summary>
    /// A collection of recommended channels for the authenticated user to follow. This data requires a bearer token with the <c>private</c> scope. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recommended_channels")]
    public RecommendedChannels? RecommendedChannels { get; init; }

    /// <summary>
    /// A collection of recommended users for the authenticated user to follow. This data requires a bearer token with the <c>private</c> scope. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recommended_users")]
    public RecommendedUsers? RecommendedUsers { get; init; }

    /// <summary>
    /// Information about the videos that have been shared with the authenticated user.
    /// </summary>
    [JsonPropertyName("shared")]
    public required Shared Shared { get; init; }

    /// <summary>
    /// Information about the videos that the authenticated user has uploaded.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos3 Videos { get; init; }

    /// <summary>
    /// Information about the user's profile.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("view_profile")]
    public ViewProfile? ViewProfile { get; init; }

    /// <summary>
    /// Information about the videos that the authenticated user has watched.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("watched_videos")]
    public WatchedVideos? WatchedVideos { get; init; }

    /// <summary>
    /// Information about the videos that the authenticated user has marked to watch later.
    /// </summary>
    [JsonPropertyName("watchlater")]
    public required Watchlater Watchlater { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

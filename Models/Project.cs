using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record Project
{
    /// <summary>
    /// The access grant response that applies to the team member. _This field is deprecated because grants are no longer exposed via API responses._
    /// </summary>
    [JsonPropertyName("access_grant")]
    public required object AccessGrant { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the folder was created.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The URI for the user who created the folder.
    /// </summary>
    [JsonPropertyName("creator_uri")]
    public required string CreatorUri { get; init; }

    /// <summary>
    /// Whether this folder has at least one subfolder.
    /// </summary>
    [JsonPropertyName("has_subfolder")]
    public required bool HasSubfolder { get; init; }

    /// <summary>
    /// Whether the folder is pinned.
    /// </summary>
    [JsonPropertyName("is_pinned")]
    public required bool IsPinned { get; init; }

    /// <summary>
    /// Whether the folder is a private-to-me folder for the user.
    /// </summary>
    [JsonPropertyName("is_private_to_user")]
    public required bool IsPrivateToUser { get; init; }

    /// <summary>
    /// Whether the current user has starred this folder.
    /// </summary>
    [JsonPropertyName("is_starred_by_cur_user")]
    public required bool IsStarredByCurUser { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when a user last performed an action on the folder.
    /// </summary>
    [JsonPropertyName("last_user_action_event_date")]
    public required string? LastUserActionEventDate { get; init; }

    /// <summary>
    /// The link to the folder on Vimeo.
    /// </summary>
    [JsonPropertyName("link")]
    public required string Link { get; init; }

    /// <summary>
    /// The link to the folder management page.
    /// </summary>
    [JsonPropertyName("manage_link")]
    public required string ManageLink { get; init; }

    /// <summary>
    /// Information about the folders's metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata5 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the folder was last modified.
    /// </summary>
    [JsonPropertyName("modified_time")]
    public required string ModifiedTime { get; init; }

    /// <summary>
    /// The name of the folder.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the folder was pinned.
    /// </summary>
    [JsonPropertyName("pinned_on")]
    public required string? PinnedOn { get; init; }

    /// <summary>
    /// The privacy settings of the folder.
    /// </summary>
    [JsonPropertyName("privacy")]
    public required Privacy2 Privacy { get; init; }

    /// <summary>
    /// The resource key string of the folder.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// All active review links associated with the folder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("review_links")]
    public IReadOnlyList<ReviewLink>? ReviewLinks { get; init; }

    /// <summary>
    /// The settings of the folder.
    /// </summary>
    [JsonPropertyName("settings")]
    public required Settings Settings { get; init; }

    /// <summary>
    /// Whether to display a folder notification that directs the current user to the team library page.
    /// </summary>
    [JsonPropertyName("should_show_team_library_notification")]
    public required bool ShouldShowTeamLibraryNotification { get; init; }

    /// <summary>
    /// The URI of the folder.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The owner of the folder.
    /// </summary>
    [JsonPropertyName("user")]
    public required User User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

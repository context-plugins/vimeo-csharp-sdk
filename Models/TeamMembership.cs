using System.Collections.Generic;
using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record TeamMembership
{
    /// <summary>
    /// Information about an access grant that applies to the team member on the folder. _This field is deprecated because grants are no longer exposed via API responses._
    /// </summary>
    [JsonPropertyName("access_grant")]
    public required object? AccessGrant { get; init; }

    /// <summary>
    /// Whether the team membership is currently active.
    /// </summary>
    [JsonPropertyName("active")]
    public required bool Active { get; init; }

    /// <summary>
    /// Information about permission policies that can apply to the team member.
    /// </summary>
    [JsonPropertyName("applicable_permission_policies")]
    public required ApplicablePermissionPolicies ApplicablePermissionPolicies { get; init; }

    /// <summary>
    /// An array of the team roles this team member can have.
    /// </summary>
    [JsonPropertyName("applicable_roles")]
    public required IReadOnlyList<TeamRole> ApplicableRoles { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the invite was sent.
    /// </summary>
    [JsonPropertyName("created_time")]
    public required string CreatedTime { get; init; }

    /// <summary>
    /// The team member's email.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; init; }

    /// <summary>
    /// Whether the team member should be excluded from single sign-on.
    /// </summary>
    [JsonPropertyName("exclude_sso")]
    public required bool? ExcludeSso { get; init; }

    /// <summary>
    /// Whether the team member has folder access.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_folder_access")]
    public bool? HasFolderAccess { get; init; }

    /// <summary>
    /// Whether the team member has an LMS user.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("has_lms_user")]
    public bool? HasLmsUser { get; init; }

    /// <summary>
    /// The URL for the invited user to join the team. The value of this field is null if the invited user has already joined.
    /// </summary>
    [JsonPropertyName("invite_url")]
    public required string? InviteUrl { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the invite was accepted.
    /// </summary>
    [JsonPropertyName("joined_time")]
    public required string JoinedTime { get; init; }

    /// <summary>
    /// The metadata of the team membership.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata26 Metadata { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the team membership was last modified.
    /// </summary>
    [JsonPropertyName("modified_time")]
    public required string ModifiedTime { get; init; }

    /// <summary>
    /// The allowable permission actions of the team user.
    /// </summary>
    [JsonPropertyName("permission_actions")]
    public required IReadOnlyList<string> PermissionActions { get; init; }

    /// <summary>
    /// The team member's permission level.
    /// <para>
    /// Option descriptions:
    ///  * <c>Admin</c> - The team member has admin permissions. They can upload and edit videos for the entire team and perform team administration tasks.
    ///  * <c>Contributor</c> - The team member has contributor permissions. They can upload and edit videos for the entire team but can't perform team administration tasks.
    ///  * <c>Contributor Plus</c> - The team member has contributor plus permissions. They can upload and edit videos for the entire team, and have additional sets of permissions, but can't perform team administration tasks.
    ///  * <c>Owner</c> - The team member has owner permissions.
    ///  * <c>Uploader</c> - The team member has uploader permissions. They can upload videos for the entire team but can't edit videos.
    ///  * <c>Viewer</c> - The team member has viewer permissions. They can access team videos and specific team folders but can't upload or edit videos.
    /// </para>
    /// </summary>
    [JsonPropertyName("permission_level")]
    public required PermissionLevel1 PermissionLevel { get; init; }

    /// <summary>
    /// Whether the team member has been reminded about the invite.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("recently_reminded")]
    public bool? RecentlyReminded { get; init; }

    /// <summary>
    /// The resource key of the team membership.
    /// </summary>
    [JsonPropertyName("resource_key")]
    public required string ResourceKey { get; init; }

    /// <summary>
    /// The team member's role, translated.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; init; }

    /// <summary>
    /// The status of the team membership invite.
    /// <para>
    /// Option descriptions:
    ///  * <c>accepted</c> - Team membership has been accepted.
    ///  * <c>pending</c> - Team membership has been offered but not yet accepted.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status21 Status { get; init; }

    /// <summary>
    /// The URI of the team membership resource.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    /// <summary>
    /// The team member. The value of this field is null if the user hasn't joined the team yet.
    /// </summary>
    [JsonPropertyName("user")]
    public required User? User { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

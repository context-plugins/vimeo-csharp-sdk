using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record TeamRole
{
    /// <summary>
    /// The applicable permission policies for the role.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("applicable_permission_policies")]
    public ApplicablePermissionPolicies1? ApplicablePermissionPolicies { get; init; }

    /// <summary>
    /// The total number of team members with this role.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("count")]
    public double? Count { get; init; }

    /// <summary>
    /// The translated display description of the role.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_description")]
    public string? DisplayDescription { get; init; }

    /// <summary>
    /// The translated display name of the role.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("display_name")]
    public string? DisplayName { get; init; }

    /// <summary>
    /// Whether the role is disabled for certain team members.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("is_disabled")]
    public bool? IsDisabled { get; init; }

    /// <summary>
    /// The untranslated role of the user who made the request.
    /// <para>
    /// Option descriptions:
    ///  * <c>Admin</c> - The team member has admin permissions. They can upload and edit videos for the entire team and perform team administration tasks.
    ///  * <c>Contributor</c> - The team member has contributor permissions. They can upload and edit videos for the entire team but can’t perform team administration tasks.
    ///  * <c>Contributor Plus</c> - The team member has contributor-plus permissions. They can upload and edit videos for the entire team and have additional sets of permissions but can't perform team administration tasks.
    ///  * <c>Owner</c> - The team member has owner permissions.
    ///  * <c>Uploader</c> - The team member has uploader permissions. They can upload videos for the entire team but can't edit videos.
    ///  * <c>Viewer</c> - The team member has viewer permissions. They can access team videos and specific team folders but can't upload or edit videos.
    /// </para>
    /// </summary>
    [JsonPropertyName("permission_level")]
    public required PermissionLevel? PermissionLevel { get; init; }

    /// <summary>
    /// The untranslated role of the user who made the request.
    /// <para>
    /// Option descriptions:
    ///  * <c>Admin</c> - The team member has admin permissions. They can upload and edit videos for the entire team and perform team administration tasks.
    ///  * <c>Contributor</c> - The team member has contributor permissions. They can upload and edit videos for the entire team but can’t perform team administration tasks.
    ///  * <c>Contributor Plus</c> - The team member has contributor-plus permissions. They can upload and edit videos for the entire team and have additional sets of permissions but can't perform team administration tasks.
    ///  * <c>Owner</c> - The team member has owner permissions.
    ///  * <c>Uploader</c> - The team member has uploader permissions. They can upload videos for the entire team but can’t edit videos.
    ///  * <c>Viewer</c> - The team member has viewer permissions. They can access team videos and specific team folders but can’t upload or edit videos.
    /// </para>
    /// </summary>
    [JsonPropertyName("role")]
    public required Role? Role { get; init; }

    /// <summary>
    /// The URI of the team role.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

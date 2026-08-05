using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// A list of resource URIs related to the folder.
/// </summary>
public record Connections5
{
    /// <summary>
    /// Information about the folder's ancestry ordered from the direct parent to higher-level ancestors.
    /// </summary>
    [JsonPropertyName("ancestor_path")]
    public required IReadOnlyList<AncestorPath1> AncestorPath { get; init; }

    [JsonPropertyName("data_retention")]
    public required DataRetention DataRetention { get; init; }

    /// <summary>
    /// A standard connection object indicating how to return all the subfolders in the folder.
    /// </summary>
    [JsonPropertyName("folders")]
    public required Folders Folders { get; init; }

    /// <summary>
    /// Information about the folder's group access grants.
    /// </summary>
    [JsonPropertyName("group_folder_grants")]
    public required GroupFolderGrants GroupFolderGrants { get; init; }

    /// <summary>
    /// A standard connection object indicating how to return all the items in the folder.
    /// </summary>
    [JsonPropertyName("items")]
    public required Items Items { get; init; }

    /// <summary>
    /// A standard connection object indicating how to return the folder's parent folder.
    /// </summary>
    [JsonPropertyName("parent_folder")]
    public required ParentFolder ParentFolder { get; init; }

    /// <summary>
    /// Information about the owner of the personal team folder.
    /// </summary>
    [JsonPropertyName("personal_team_folder_owner")]
    public required PersonalTeamFolderOwner PersonalTeamFolderOwner { get; init; }

    /// <summary>
    /// Information about the team user who created the folder. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("resource_creator_team_user")]
    public required ResourceCreatorTeamUser1 ResourceCreatorTeamUser { get; init; }

    /// <summary>
    /// Information about the folder's team permissions list. This data requires a bearer token with the <c>private</c> scope.
    /// </summary>
    [JsonPropertyName("team_permissions")]
    public required TeamPermissions1 TeamPermissions { get; init; }

    /// <summary>
    /// Information about the folder's user folder access grants.
    /// </summary>
    [JsonPropertyName("user_folder_access_grants")]
    public required UserFolderAccessGrants UserFolderAccessGrants { get; init; }

    /// <summary>
    /// A standard connection object indicating how to return all the videos in the folder.
    /// </summary>
    [JsonPropertyName("videos")]
    public required Videos5 Videos { get; init; }
}

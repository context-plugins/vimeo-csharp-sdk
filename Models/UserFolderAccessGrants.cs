using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about the folder's user folder access grants.
/// </summary>
public record UserFolderAccessGrants
{
    /// <summary>
    /// Information about the owner's folder permission policies.
    /// </summary>
    [JsonPropertyName("folder_permission_policies")]
    public required IReadOnlyList<FolderPermissionPolicy> FolderPermissionPolicies { get; init; }

    /// <summary>
    /// An array of HTTP methods permitted on this URI.
    /// </summary>
    [JsonPropertyName("options")]
    public required IReadOnlyList<string> Options { get; init; }

    /// <summary>
    /// The total number of user folder access grants on this connection.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; init; }

    /// <summary>
    /// The API URI that resolves to the connection data.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }
}

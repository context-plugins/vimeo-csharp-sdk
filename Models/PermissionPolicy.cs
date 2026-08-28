using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

public record PermissionPolicy
{
    /// <summary>
    /// The time at which the permission policy was created.
    /// </summary>
    [JsonPropertyName("created_on")]
    public required string CreatedOn { get; init; }

    /// <summary>
    /// The display description of the permission policy, translated where applicable.
    /// </summary>
    [JsonPropertyName("display_description")]
    public required string DisplayDescription { get; init; }

    /// <summary>
    /// The display name of the permission policy, translated where applicable.
    /// </summary>
    [JsonPropertyName("display_name")]
    public required string DisplayName { get; init; }

    /// <summary>
    /// The time at which the permission policy was last modified.
    /// </summary>
    [JsonPropertyName("modified_on")]
    public required string? ModifiedOn { get; init; }

    /// <summary>
    /// The name of the permission policy.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// The permission actions associated with the policy.
    /// </summary>
    [JsonPropertyName("permission_actions")]
    public required object PermissionActions { get; init; }

    /// <summary>
    /// The URI of the permission policy.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

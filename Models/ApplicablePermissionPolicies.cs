using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// Information about permission policies that can apply to the team member.
/// </summary>
public record ApplicablePermissionPolicies
{
    /// <summary>
    /// An array of folder permission policies that can apply to the team member.
    /// </summary>
    [JsonPropertyName("folder")]
    public required IReadOnlyList<PermissionPolicy> Folder { get; init; }

    /// <summary>
    /// An array of regional delivery permission policies that can apply to the team member.
    /// </summary>
    [JsonPropertyName("regional_delivery")]
    public required IReadOnlyList<PermissionPolicy> RegionalDelivery { get; init; }

    /// <summary>
    /// An array of video permission policies that can apply to the team member.
    /// </summary>
    [JsonPropertyName("video")]
    public required IReadOnlyList<PermissionPolicy> Video { get; init; }
}

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace VimeoApi.Models;

/// <summary>
/// The applicable permission policies for the role.
/// </summary>
public record ApplicablePermissionPolicies1
{
    /// <summary>
    /// The applicable folder-related permission policies for the role.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("folder")]
    public IReadOnlyList<string>? Folder { get; init; }

    /// <summary>
    /// The applicable permission policies related to regional delivery for the role.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("regional_delivery")]
    public IReadOnlyList<RegionalDelivery>? RegionalDelivery { get; init; }

    /// <summary>
    /// The applicable video-related permission policies for the role.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("video")]
    public IReadOnlyList<string>? Video { get; init; }
}

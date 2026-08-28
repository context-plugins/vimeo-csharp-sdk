using System.Text.Json.Serialization;
using Vimeo.Core.Models;

namespace Vimeo.Models;

/// <summary>
/// The upload quota. This information appears only when the authenticated user has upload access and is looking at their own user record.
/// </summary>
public record UploadQuota
{
    /// <summary>
    /// Information about the authenticated user's lifetime upload usage.
    /// </summary>
    [JsonPropertyName("lifetime")]
    public required Lifetime Lifetime { get; init; }

    /// <summary>
    /// Information about the authenticated user's usage for the current period.
    /// </summary>
    [JsonPropertyName("periodic")]
    public required Periodic Periodic { get; init; }

    /// <summary>
    /// The number of bytes used by videos currently in the Recently Deleted folder.
    /// </summary>
    [JsonPropertyName("recently_deleted_disk_space")]
    public required double RecentlyDeletedDiskSpace { get; init; }

    /// <summary>
    /// The restricted video storage quota (for embeddable and private videos).
    /// </summary>
    [JsonPropertyName("restricted")]
    public required Restricted Restricted { get; init; }

    /// <summary>
    /// Information about the authenticated user's upload space remaining for the current period.
    /// </summary>
    [JsonPropertyName("space")]
    public required Space Space { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

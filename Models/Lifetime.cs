using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// Information about the authenticated user's lifetime upload usage.
/// </summary>
public record Lifetime
{
    /// <summary>
    /// The number of bytes or videos remaining in the authenticated user's lifetime maximum.
    /// </summary>
    [JsonPropertyName("free")]
    public required double? Free { get; init; }

    /// <summary>
    /// The total number of bytes or videos that the authenticated user can upload across the lifetime of their account.
    /// </summary>
    [JsonPropertyName("max")]
    public required double? Max { get; init; }

    /// <summary>
    /// The unit that's used to compute quota.
    /// <para>
    /// Option descriptions:
    ///  * <c>video_count</c> - The quota is calculated using the count of the videos.
    ///  * <c>video_size</c> - The quota is calculated using the byte size of the videos.
    /// </para>
    /// </summary>
    [JsonPropertyName("unit")]
    public required Unit? Unit { get; init; }

    /// <summary>
    /// The number of bytes or videos that the authenticated user has already uploaded against their lifetime limit.
    /// </summary>
    [JsonPropertyName("used")]
    public required double? Used { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

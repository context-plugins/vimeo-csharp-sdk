using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about the authenticated user's usage for the current period.
/// </summary>
public record Periodic
{
    /// <summary>
    /// The number of bytes or video count remaining in the authenticated user's upload quota for the current period.
    /// </summary>
    [JsonPropertyName("free")]
    public required double? Free { get; init; }

    /// <summary>
    /// The total number of bytes or videos that the authenticated user can upload per period.
    /// </summary>
    [JsonPropertyName("max")]
    public required double? Max { get; init; }

    /// <summary>
    /// The renewal frequency of the quota.
    /// <para>
    /// Option descriptions:
    ///  * <c>lifetime</c> - The user doesn't have a periodic quota.
    ///  * <c>month</c> - The quota renews monthly.
    ///  * <c>week</c> - The quota renews weekly.
    ///  * <c>year</c> - The quota renews yearly.
    /// </para>
    /// </summary>
    [JsonPropertyName("period")]
    public required Period3? Period { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the authenticated user's upload quota resets.
    /// </summary>
    [JsonPropertyName("reset_date")]
    public required string? ResetDate { get; init; }

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
    /// The number of bytes or video count that the authenticated user has already uploaded against their quota in the current period.
    /// </summary>
    [JsonPropertyName("used")]
    public required double? Used { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

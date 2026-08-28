using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

/// <summary>
/// The list of entitlement parameters corresponding to the tier.
/// </summary>
public record Params
{
    /// <summary>
    /// AI credits entitlements information.
    /// </summary>
    [JsonPropertyName("ai")]
    public required Ai Ai { get; init; }

    /// <summary>
    /// Bandwidth entitlement information.
    /// </summary>
    [JsonPropertyName("bandwidth")]
    public required Bandwidth1 Bandwidth { get; init; }

    /// <summary>
    /// The restricted video storage limit for the tier, formatted as a human-readable byte string (e.g. "1GB", "50GB", "7TB"). Null means unlimited.
    /// </summary>
    [JsonPropertyName("restricted_video_storage_limit")]
    public required string? RestrictedVideoStorageLimit { get; init; }

    /// <summary>
    /// Team seats entitlement information.
    /// </summary>
    [JsonPropertyName("seats")]
    public required Seats Seats { get; init; }

    /// <summary>
    /// Video storage entitlement information.
    /// </summary>
    [JsonPropertyName("storage")]
    public required Storage Storage { get; init; }

    /// <summary>
    /// The number of team seats included with the tier for the monthly plan.
    /// </summary>
    [JsonPropertyName("team_seats")]
    public required double? TeamSeats { get; init; }

    /// <summary>
    /// The amount of video storage for the user's periodic quota for the annual plan.
    /// </summary>
    [JsonPropertyName("video_storage_periodic_quota")]
    public required string? VideoStoragePeriodicQuota { get; init; }

    /// <summary>
    /// The video storage total lifetime cap for the annual plan.
    /// </summary>
    [JsonPropertyName("video_storage_quota_cap")]
    public required string? VideoStorageQuotaCap { get; init; }

    /// <summary>
    /// The video storage quota period for the annual plan.
    /// <para>
    /// Option descriptions:
    ///  * <c>lifetime</c> - The product has a lifetime video storage quota period.
    ///  * <c>month</c> - The product has a monthly video storage quota period.
    ///  * <c>week</c> - The product has a weekly video storage quota period.
    ///  * <c>year</c> - The product has a yearly video storage quota period.
    /// </para>
    /// </summary>
    [JsonPropertyName("video_storage_quota_period")]
    public required VideoStorageQuotaPeriod VideoStorageQuotaPeriod { get; init; }

    /// <summary>
    /// The unit of the video storage for the user's periodic quota for the annual plan.
    /// <para>
    /// Option descriptions:
    ///  * <c>video_count</c> - The product has video storage based on video count.
    ///  * <c>video_size</c> - The product has video storage based on video size.
    /// </para>
    /// </summary>
    [JsonPropertyName("video_storage_quota_unit")]
    public required VideoStorageQuotaUnit VideoStorageQuotaUnit { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

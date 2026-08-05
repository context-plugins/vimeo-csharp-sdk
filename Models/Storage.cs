using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Video storage entitlement information.
/// </summary>
public record Storage
{
    /// <summary>
    /// The amount of video storage for the user's periodic quota for the annual plan.
    /// </summary>
    [JsonPropertyName("periodic_quota")]
    public required string? PeriodicQuota { get; init; }

    /// <summary>
    /// The video storage total lifetime cap for the annual plan.
    /// </summary>
    [JsonPropertyName("quota_cap")]
    public required string? QuotaCap { get; init; }

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
    [JsonPropertyName("quota_period")]
    public required QuotaPeriod1 QuotaPeriod { get; init; }

    /// <summary>
    /// The unit of the video storage for the user's periodic quota for the annual plan.
    /// <para>
    /// Option descriptions:
    ///  * <c>video_count</c> - The product has video storage based on video count.
    ///  * <c>video_size</c> - The product has video storage based on video size.
    /// </para>
    /// </summary>
    [JsonPropertyName("quota_unit")]
    public required QuotaUnit QuotaUnit { get; init; }
}

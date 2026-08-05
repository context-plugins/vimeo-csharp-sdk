using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Bandwidth entitlement information.
/// </summary>
public record Bandwidth1
{
    /// <summary>
    /// The amount of bandwidth for the user's period.
    /// </summary>
    [JsonPropertyName("periodic_quota")]
    public required string? PeriodicQuota { get; init; }

    /// <summary>
    /// The quota period unit for the user's bandwidth quota.
    /// <para>
    /// Option descriptions:
    ///  * <c>month</c> - The product has a monthly bandwidth quota period.
    ///  * <c>week</c> - The product has a weekly bandwidth quota period.
    ///  * <c>year</c> - The product has a yearly bandwidth quota period.
    /// </para>
    /// </summary>
    [JsonPropertyName("quota_period")]
    public required QuotaPeriod QuotaPeriod { get; init; }
}

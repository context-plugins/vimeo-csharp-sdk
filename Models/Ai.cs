using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// AI credits entitlements information.
/// </summary>
public record Ai
{
    /// <summary>
    /// The quota period unit for the user's AI credits quota.
    /// <para>
    /// Option descriptions:
    ///  * <c>month</c> - The product has a monthly AI credits quota period.
    ///  * <c>week</c> - The product has a weekly AI credits quota period.
    ///  * <c>year</c> - The product has a yearly AI credits quota period.
    /// </para>
    /// </summary>
    [JsonPropertyName("credits_period")]
    public required CreditsPeriod CreditsPeriod { get; init; }

    /// <summary>
    /// The number of AI credits for the user's period.
    /// </summary>
    [JsonPropertyName("periodic_credits")]
    public required double? PeriodicCredits { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

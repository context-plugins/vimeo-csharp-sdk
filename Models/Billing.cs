using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about the authenticated user's subscription billing.
/// </summary>
public record Billing
{
    /// <summary>
    /// The billing status of the subscription.
    /// <para>
    /// Option descriptions:
    ///  * <c>active</c> - The subscription is in good standing and will renew automatically on the renewal date.
    ///  * <c>cancelled</c> - The subscription is or will become inactive on the expiration date and won't renew automatically.
    ///  * <c>grace_period</c> - The subscription has passed the expiration date but is still active. The automatic renewal charge is being retried.
    ///  * <c>none</c> - The subscription doesn't exist. A subscription in this state can be considered as erroring.
    ///  * <c>on_hold</c> - The subscription's automatic renewal payment has failed, and the grace period has expired.
    ///  * <c>pending</c> - The status of the subscription is pending. A subscription in this state can be considered as erroring.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status Status { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

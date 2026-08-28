using System.Collections.Generic;
using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Subscription
{
    /// <summary>
    /// The ID of the account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// Whether the subscription is set to renew automatically.
    /// </summary>
    [JsonPropertyName("auto_renew")]
    public required bool AutoRenew { get; init; }

    /// <summary>
    /// Whether the user can extend their subscription's expiration date by an additional billing period for the same product tier.
    /// </summary>
    [JsonPropertyName("can_renew_now")]
    public required bool CanRenewNow { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the subscription was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the subscription was disabled.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("disabled_at")]
    public string? DisabledAt { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the subscription ended.
    /// </summary>
    [JsonPropertyName("end_date")]
    public required string EndDate { get; init; }

    /// <summary>
    /// The ID of the grace period.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("grace_period_id")]
    public string? GracePeriodId { get; init; }

    /// <summary>
    /// The ID of the subscription.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Whether the subscription is the latest version.
    /// </summary>
    [JsonPropertyName("is_latest")]
    public required bool IsLatest { get; init; }

    /// <summary>
    /// The ID of the payment method.
    /// </summary>
    [JsonPropertyName("payment_method_id")]
    public required string PaymentMethodId { get; init; }

    /// <summary>
    /// An array of plans in the subscription.
    /// </summary>
    [JsonPropertyName("plans")]
    public required IReadOnlyList<Plan> Plans { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the subscription started.
    /// </summary>
    [JsonPropertyName("start_date")]
    public required string StartDate { get; init; }

    /// <summary>
    /// The status of the subscription.
    /// <para>
    /// Option descriptions:
    ///  * <c>SUBSCRIPTION_STATUS_ACTIVE</c> - The subscription is active.
    ///  * <c>SUBSCRIPTION_STATUS_CANCELLED</c> - The subscription is canceled.
    ///  * <c>SUBSCRIPTION_STATUS_DRAFT</c> - The subscription is a draft.
    ///  * <c>SUBSCRIPTION_STATUS_EXPIRED</c> - The subscription is expired.
    ///  * <c>SUBSCRIPTION_STATUS_PAUSED</c> - The subscription is paused.
    ///  * <c>SUBSCRIPTION_STATUS_PENDING_ACCEPTANCE</c> - The subscription is pending acceptance.
    ///  * <c>SUBSCRIPTION_STATUS_PENDING_ACTIVATION</c> - The subscription is pending activation.
    ///  * <c>SUBSCRIPTION_STATUS_UNSPECIFIED</c> - The subscription status is unspecified.
    /// </para>
    /// </summary>
    [JsonPropertyName("status")]
    public required Status19 Status { get; init; }

    /// <summary>
    /// The number of the subscription.
    /// </summary>
    [JsonPropertyName("subscription_number")]
    public required string SubscriptionNumber { get; init; }

    /// <summary>
    /// The version of the subscription.
    /// </summary>
    [JsonPropertyName("subscription_version")]
    public required double SubscriptionVersion { get; init; }

    /// <summary>
    /// The time in ISO 8601 format when the subscription was updated.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required string UpdatedAt { get; init; }

    /// <summary>
    /// The vendor of the subscription.
    /// </summary>
    [JsonPropertyName("vendor")]
    public required string Vendor { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

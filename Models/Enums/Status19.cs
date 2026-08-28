using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Status19>))]
public sealed record Status19 : StringEnum<Status19>
{
    private Status19(string value) : base(value)
    {
    }

    public static readonly Status19 SubscriptionStatusActive = new("SUBSCRIPTION_STATUS_ACTIVE");

    public static readonly Status19 SubscriptionStatusCancelled = new("SUBSCRIPTION_STATUS_CANCELLED");

    public static readonly Status19 SubscriptionStatusDraft = new("SUBSCRIPTION_STATUS_DRAFT");

    public static readonly Status19 SubscriptionStatusExpired = new("SUBSCRIPTION_STATUS_EXPIRED");

    public static readonly Status19 SubscriptionStatusPaused = new("SUBSCRIPTION_STATUS_PAUSED");

    public static readonly Status19 SubscriptionStatusPendingAcceptance = new("SUBSCRIPTION_STATUS_PENDING_ACCEPTANCE");

    public static readonly Status19 SubscriptionStatusPendingActivation = new("SUBSCRIPTION_STATUS_PENDING_ACTIVATION");

    public static readonly Status19 SubscriptionStatusUnspecified = new("SUBSCRIPTION_STATUS_UNSPECIFIED");

    public static Status19 FromValue(string value) => FromValueCore(value);
}

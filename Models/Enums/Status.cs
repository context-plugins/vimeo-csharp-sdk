using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Status>))]
public sealed record Status : StringEnum<Status>
{
    private Status(string value) : base(value)
    {
    }

    public static readonly Status Active = new("active");

    public static readonly Status Cancelled = new("cancelled");

    public static readonly Status GracePeriod = new("grace_period");

    public static readonly Status None = new("none");

    public static readonly Status OnHold = new("on_hold");

    public static readonly Status Pending = new("pending");

    public static Status FromValue(string value) => FromValueCore(value);
}

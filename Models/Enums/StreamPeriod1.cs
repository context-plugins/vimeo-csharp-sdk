using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The amount of time for which the user can access On Demand content upon redeeming a promotion code. This parameter is required only when the streaming period isn't defined in the On Demand container, or when creating promotions where <b>access_type</b> is <c>vip</c> or <b>product_type</b> is <c>rent</c>.
/// <para>
/// Option descriptions:
///  * <c>1_week</c> - The user can access On Demand content for a maximum of 1 week after redeeming a promotion code.
///  * <c>1_year</c> - The user can access On Demand content for a maximum of 1 year after redeeming a promotion code.
///  * <c>3_month</c> - The user can access On Demand content for a maximum of 3 months after redeeming a promotion code.
///  * <c>6_month</c> - The user can access On Demand content for a maximum of 6 months after redeeming a promotion code.
///  * <c>24_hour</c> - The user can access On Demand content for a maximum of 24 hours after redeeming a promotion code.
///  * <c>30_day</c> - The user can access On Demand content for a maximum of 30 days after redeeming a promotion code.
///  * <c>48_hour</c> - The user can access On Demand content for a maximum of 48 hours after redeeming a promotion code.
///  * <c>72_hour</c> - The user can access On Demand content for a maximum of 72 hours after redeeming a promotion code.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StreamPeriod1>))]
public sealed record StreamPeriod1 : StringEnum<StreamPeriod1>
{
    private StreamPeriod1(string value) : base(value)
    {
    }

    public static readonly StreamPeriod1 _1Week = new("1_week");

    public static readonly StreamPeriod1 _1Year = new("1_year");

    public static readonly StreamPeriod1 _3Month = new("3_month");

    public static readonly StreamPeriod1 _6Month = new("6_month");

    public static readonly StreamPeriod1 _24Hour = new("24_hour");

    public static readonly StreamPeriod1 _30Day = new("30_day");

    public static readonly StreamPeriod1 _48Hour = new("48_hour");

    public static readonly StreamPeriod1 _72Hour = new("72_hour");

    public static StreamPeriod1 FromValue(string value) => FromValueCore(value);
}

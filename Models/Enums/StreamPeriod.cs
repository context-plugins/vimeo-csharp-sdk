using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The amount of time that the user has access to the On Demand content after redeeming a promotional code.
/// <para>
/// Option descriptions:
///  * <c>1_week</c> - Access lasts for one week.
///  * <c>1_year</c> - Access lasts for one year.
///  * <c>3_month</c> - Access lasts for three months.
///  * <c>6_month</c> - Access lasts for six months.
///  * <c>24_hour</c> - Access lasts for 24 hours.
///  * <c>30_days</c> - Access lasts for 30 days.
///  * <c>48_hour</c> - Access lasts for 48 hours.
///  * <c>72_hour</c> - Access lasts for 72 hours.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StreamPeriod>))]
public sealed record StreamPeriod : StringEnum<StreamPeriod>
{
    private StreamPeriod(string value) : base(value)
    {
    }

    public static readonly StreamPeriod _1Week = new("1_week");

    public static readonly StreamPeriod _1Year = new("1_year");

    public static readonly StreamPeriod _3Month = new("3_month");

    public static readonly StreamPeriod _6Month = new("6_month");

    public static readonly StreamPeriod _24Hour = new("24_hour");

    public static readonly StreamPeriod _30Days = new("30_days");

    public static readonly StreamPeriod _48Hour = new("48_hour");

    public static readonly StreamPeriod _72Hour = new("72_hour");

    public static StreamPeriod FromValue(string value) => FromValueCore(value);
}

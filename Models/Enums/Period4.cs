using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The rental period for the video.
/// <para>
/// Option descriptions:
///  * <c>1 day</c> - The rental period is one day.
///  * <c>1 month</c> - The rental period is one month.
///  * <c>1 week</c> - The rental period is one week.
///  * <c>1 year</c> - The rental period is one year.
///  * <c>2 day</c> - The rental period is two days.
///  * <c>3 day</c> - The rental period is three days.
///  * <c>3 month</c> - The rental period is three months.
///  * <c>6 month</c> - The rental period is six months.
///  * <c>7 day</c> - The rental period is seven days.
///  * <c>24 hour</c> - The rental period is 24 hours.
///  * <c>30 day</c> - The rental period is 30 days.
///  * <c>48 hour</c> - The rental period is 48 hours.
///  * <c>60 day</c> - The rental period is 60 days.
///  * <c>72 hour</c> - The rental period is 72 hours.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Period4>))]
public sealed record Period4 : StringEnum<Period4>
{
    private Period4(string value) : base(value)
    {
    }

    public static readonly Period4 _1Day = new("1 day");

    public static readonly Period4 _1Month = new("1 month");

    public static readonly Period4 _1Week = new("1 week");

    public static readonly Period4 _1Year = new("1 year");

    public static readonly Period4 _2Day = new("2 day");

    public static readonly Period4 _3Day = new("3 day");

    public static readonly Period4 _3Month = new("3 month");

    public static readonly Period4 _6Month = new("6 month");

    public static readonly Period4 _7Day = new("7 day");

    public static readonly Period4 _24Hour = new("24 hour");

    public static readonly Period4 _30Day = new("30 day");

    public static readonly Period4 _48Hour = new("48 hour");

    public static readonly Period4 _60Day = new("60 day");

    public static readonly Period4 _72Hour = new("72 hour");

    public static Period4 FromValue(string value) => FromValueCore(value);
}

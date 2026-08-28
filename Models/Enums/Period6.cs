using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The rental period of the video.
/// <para>
/// Option descriptions:
///  * <c>1 week</c> - The video can be rented for a maximum of 1 week.
///  * <c>1 year</c> - The video can be rented for a maximum of 1 year.
///  * <c>3 month</c> - The video can be rented for a maximum of 3 months.
///  * <c>6 month</c> - The video can be rented for a maximum of 6 months.
///  * <c>24 hour</c> - The video can be rented for a maximum of 24 hours.
///  * <c>30 day</c> - The video can be rented for a maximum of 30 days.
///  * <c>48 hour</c> - The video can be rented for a maximum of 48 hours.
///  * <c>72 hour</c> - The video can be rented for a maximum of 72 hours.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Period6>))]
public sealed record Period6 : StringEnum<Period6>
{
    private Period6(string value) : base(value)
    {
    }

    public static readonly Period6 _1Week = new("1 week");

    public static readonly Period6 _1Year = new("1 year");

    public static readonly Period6 _3Month = new("3 month");

    public static readonly Period6 _6Month = new("6 month");

    public static readonly Period6 _24Hour = new("24 hour");

    public static readonly Period6 _30Day = new("30 day");

    public static readonly Period6 _48Hour = new("48 hour");

    public static readonly Period6 _72Hour = new("72 hour");

    public static Period6 FromValue(string value) => FromValueCore(value);
}

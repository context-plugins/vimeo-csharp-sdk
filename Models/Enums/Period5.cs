using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The rental period of the episode.
/// <para>
/// Option descriptions:
///  * <c>1 week</c> - The episode can be rented for a maximum of 1 week.
///  * <c>1 year</c> - The episode can be rented for a maximum of 1 year.
///  * <c>3 month</c> - The episode can be rented for a maximum of 3 months.
///  * <c>6 month</c> - The episode can be rented for a maximum of 6 months.
///  * <c>24 hour</c> - The episode can be rented for a maximum of 24 hours.
///  * <c>30 day</c> - The episode can be rented for a maximum of 30 days.
///  * <c>48 hour</c> - The episode can be rented for a maximum of 48 hours.
///  * <c>72 hour</c> - The episode can be rented for a maximum of 72 hours.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Period5>))]
public sealed record Period5 : StringEnum<Period5>
{
    private Period5(string value) : base(value)
    {
    }

    public static readonly Period5 _1Week = new("1 week");

    public static readonly Period5 _1Year = new("1 year");

    public static readonly Period5 _3Month = new("3 month");

    public static readonly Period5 _6Month = new("6 month");

    public static readonly Period5 _24Hour = new("24 hour");

    public static readonly Period5 _30Day = new("30 day");

    public static readonly Period5 _48Hour = new("48 hour");

    public static readonly Period5 _72Hour = new("72 hour");

    public static Period5 FromValue(string value) => FromValueCore(value);
}

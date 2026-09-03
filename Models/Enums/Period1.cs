using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The quota period for which the bandwidth is evaluated.
/// <para>
/// Option descriptions:
///  * <c>calendar_month</c> - The quota period is one month.
///  * <c>year</c> - The quota period is one year.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Period1>))]
public sealed record Period1 : StringEnum<Period1>
{
    private Period1(string value) : base(value)
    {
    }

    public static readonly Period1 CalendarMonth = new("calendar_month");

    public static readonly Period1 Year = new("year");

    public static Period1 FromValue(string value) => FromValueCore(value);
}

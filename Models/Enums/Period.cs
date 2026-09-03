using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The time period for which the AI credit activity is evaluated.
/// <para>
/// Option descriptions:
///  * <c>lifetime</c> - The quota period is for the lifetime of the account.
///  * <c>month</c> - The quota period is one month.
///  * <c>week</c> - The quota period is one week.
///  * <c>year</c> - The quota period is one year.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Period>))]
public sealed record Period : StringEnum<Period>
{
    private Period(string value) : base(value)
    {
    }

    public static readonly Period Lifetime = new("lifetime");

    public static readonly Period Month = new("month");

    public static readonly Period Week = new("week");

    public static readonly Period Year = new("year");

    public static Period FromValue(string value) => FromValueCore(value);
}

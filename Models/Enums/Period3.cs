using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The renewal frequency of the quota.
/// <para>
/// Option descriptions:
///  * <c>lifetime</c> - The user doesn't have a periodic quota.
///  * <c>month</c> - The quota renews monthly.
///  * <c>week</c> - The quota renews weekly.
///  * <c>year</c> - The quota renews yearly.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Period3>))]
public sealed record Period3 : StringEnum<Period3>
{
    private Period3(string value) : base(value)
    {
    }

    public static readonly Period3 Lifetime = new("lifetime");

    public static readonly Period3 Month = new("month");

    public static readonly Period3 Week = new("week");

    public static readonly Period3 Year = new("year");

    public static Period3 FromValue(string value) => FromValueCore(value);
}

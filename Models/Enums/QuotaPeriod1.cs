using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The video storage quota period for the annual plan.
/// <para>
/// Option descriptions:
///  * <c>lifetime</c> - The product has a lifetime video storage quota period.
///  * <c>month</c> - The product has a monthly video storage quota period.
///  * <c>week</c> - The product has a weekly video storage quota period.
///  * <c>year</c> - The product has a yearly video storage quota period.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<QuotaPeriod1>))]
public sealed record QuotaPeriod1 : StringEnum<QuotaPeriod1>
{
    private QuotaPeriod1(string value) : base(value)
    {
    }

    public static readonly QuotaPeriod1 Lifetime = new("lifetime");

    public static readonly QuotaPeriod1 Month = new("month");

    public static readonly QuotaPeriod1 Week = new("week");

    public static readonly QuotaPeriod1 Year = new("year");

    public static QuotaPeriod1 FromValue(string value) => FromValueCore(value);
}

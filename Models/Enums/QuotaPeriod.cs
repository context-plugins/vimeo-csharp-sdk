using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The quota period unit for the user's bandwidth quota.
/// <para>
/// Option descriptions:
///  * <c>month</c> - The product has a monthly bandwidth quota period.
///  * <c>week</c> - The product has a weekly bandwidth quota period.
///  * <c>year</c> - The product has a yearly bandwidth quota period.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<QuotaPeriod>))]
public sealed record QuotaPeriod : StringEnum<QuotaPeriod>
{
    private QuotaPeriod(string value) : base(value)
    {
    }

    public static readonly QuotaPeriod Month = new("month");

    public static readonly QuotaPeriod Week = new("week");

    public static readonly QuotaPeriod Year = new("year");

    public static QuotaPeriod FromValue(string value) => FromValueCore(value);
}

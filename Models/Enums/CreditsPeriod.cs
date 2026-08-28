using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The quota period unit for the user's AI credits quota.
/// <para>
/// Option descriptions:
///  * <c>month</c> - The product has a monthly AI credits quota period.
///  * <c>week</c> - The product has a weekly AI credits quota period.
///  * <c>year</c> - The product has a yearly AI credits quota period.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<CreditsPeriod>))]
public sealed record CreditsPeriod : StringEnum<CreditsPeriod>
{
    private CreditsPeriod(string value) : base(value)
    {
    }

    public static readonly CreditsPeriod Month = new("month");

    public static readonly CreditsPeriod Week = new("week");

    public static readonly CreditsPeriod Year = new("year");

    public static CreditsPeriod FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<VideoStorageQuotaPeriod>))]
public sealed record VideoStorageQuotaPeriod : StringEnum<VideoStorageQuotaPeriod>
{
    private VideoStorageQuotaPeriod(string value) : base(value)
    {
    }

    public static readonly VideoStorageQuotaPeriod Lifetime = new("lifetime");

    public static readonly VideoStorageQuotaPeriod Month = new("month");

    public static readonly VideoStorageQuotaPeriod Week = new("week");

    public static readonly VideoStorageQuotaPeriod Year = new("year");

    public static VideoStorageQuotaPeriod FromValue(string value) => FromValueCore(value);
}

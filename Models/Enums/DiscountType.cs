using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of discount that the promotion provides.
/// <para>
/// Option descriptions:
///  * <c>dollars</c> - The promotion discounts a fixed amount from the full purchase price.
///  * <c>free</c> - The promotion discounts the full purchase price. When <b>access_type</b> is <c>vip</c>, <b>discount_type</b> is always <c>free</c>.
///  * <c>percent</c> - The promotion discounts a percentage of the full purchase price.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DiscountType>))]
public sealed record DiscountType : StringEnum<DiscountType>
{
    private DiscountType(string value) : base(value)
    {
    }

    public static readonly DiscountType Dollars = new("dollars");

    public static readonly DiscountType Free = new("free");

    public static readonly DiscountType Percent = new("percent");

    public static DiscountType FromValue(string value) => FromValueCore(value);
}

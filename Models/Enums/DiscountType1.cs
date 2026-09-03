using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of discount offered by the promotion code. When <b>access_type</b> is <c>vip</c>, the value of this parameter must be <c>free</c>.
/// <para>
/// Option descriptions:
///  * <c>free</c> - The discount reduces the price to zero.
///  * <c>percent</c> - The discount reduces the price by the percentage defined in the <b>percent_off</b> parameter.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<DiscountType1>))]
public sealed record DiscountType1 : StringEnum<DiscountType1>
{
    private DiscountType1(string value) : base(value)
    {
    }

    public static readonly DiscountType1 Free = new("free");

    public static readonly DiscountType1 Percent = new("percent");

    public static DiscountType1 FromValue(string value) => FromValueCore(value);
}

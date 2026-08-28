using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The brand of the card.
/// <para>
/// Option descriptions:
///  * <c>CARD_BRAND_AMERICAN_EXPRESS</c> - The card brand is American Express.
///  * <c>CARD_BRAND_DISCOVER</c> - The card brand is Discover.
///  * <c>CARD_BRAND_JCB</c> - The card brand is JCB.
///  * <c>CARD_BRAND_MASTER_CARD</c> - The card brand is Mastercard.
///  * <c>CARD_BRAND_UNION_PAY</c> - The card brand is UnionPay.
///  * <c>CARD_BRAND_UNSPECIFIED</c> - The card brand is unspecified.
///  * <c>CARD_BRAND_VISA</c> - The card brand is Visa.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Brand>))]
public sealed record Brand : StringEnum<Brand>
{
    private Brand(string value) : base(value)
    {
    }

    public static readonly Brand CardBrandAmericanExpress = new("CARD_BRAND_AMERICAN_EXPRESS");

    public static readonly Brand CardBrandDiscover = new("CARD_BRAND_DISCOVER");

    public static readonly Brand CardBrandJcb = new("CARD_BRAND_JCB");

    public static readonly Brand CardBrandMasterCard = new("CARD_BRAND_MASTER_CARD");

    public static readonly Brand CardBrandUnionPay = new("CARD_BRAND_UNION_PAY");

    public static readonly Brand CardBrandUnspecified = new("CARD_BRAND_UNSPECIFIED");

    public static readonly Brand CardBrandVisa = new("CARD_BRAND_VISA");

    public static Brand FromValue(string value) => FromValueCore(value);
}

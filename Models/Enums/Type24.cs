using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of payment method.
/// <para>
/// Option descriptions:
///  * <c>PAYMENT_METHOD_TYPES_APPLEPAY</c> - The payment method is Apple Pay.
///  * <c>PAYMENT_METHOD_TYPES_BANK_ACCOUNT</c> - The payment method is a bank account.
///  * <c>PAYMENT_METHOD_TYPES_CARD</c> - The payment method is a card.
///  * <c>PAYMENT_METHOD_TYPES_CC_REF</c> - The payment method is a credit card reference.
///  * <c>PAYMENT_METHOD_TYPES_GOOGLEPAY</c> - The payment method is Google Pay.
///  * <c>PAYMENT_METHOD_TYPES_PAYPAL</c> - The payment method is a PayPal account.
///  * <c>PAYMENT_METHOD_TYPES_TYPES_UNSPECIFIED</c> - The payment method type is unspecified.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type24>))]
public sealed record Type24 : StringEnum<Type24>
{
    private Type24(string value) : base(value)
    {
    }

    public static readonly Type24 PaymentMethodTypesApplepay = new("PAYMENT_METHOD_TYPES_APPLEPAY");

    public static readonly Type24 PaymentMethodTypesBankAccount = new("PAYMENT_METHOD_TYPES_BANK_ACCOUNT");

    public static readonly Type24 PaymentMethodTypesCard = new("PAYMENT_METHOD_TYPES_CARD");

    public static readonly Type24 PaymentMethodTypesCcRef = new("PAYMENT_METHOD_TYPES_CC_REF");

    public static readonly Type24 PaymentMethodTypesGooglepay = new("PAYMENT_METHOD_TYPES_GOOGLEPAY");

    public static readonly Type24 PaymentMethodTypesPaypal = new("PAYMENT_METHOD_TYPES_PAYPAL");

    public static readonly Type24 PaymentMethodTypesTypesUnspecified = new("PAYMENT_METHOD_TYPES_TYPES_UNSPECIFIED");

    public static Type24 FromValue(string value) => FromValueCore(value);
}

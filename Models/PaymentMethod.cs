using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record PaymentMethod
{
    /// <summary>
    /// The ID of the account.
    /// </summary>
    [JsonPropertyName("account_id")]
    public required string AccountId { get; init; }

    /// <summary>
    /// Information about the card used to make the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("card")]
    public Card1? Card { get; init; }

    /// <summary>
    /// The time when the payment method was created.
    /// </summary>
    [JsonPropertyName("created_at")]
    public required string CreatedAt { get; init; }

    /// <summary>
    /// The time when the payment method was disabled.
    /// </summary>
    [JsonPropertyName("disabled_at")]
    public required string DisabledAt { get; init; }

    /// <summary>
    /// The ID of the payment method.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>
    /// Whether the payment method is the default payment method for the account.
    /// </summary>
    [JsonPropertyName("is_default")]
    public required bool IsDefault { get; init; }

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
    [JsonPropertyName("type")]
    public required Type24 Type { get; init; }

    /// <summary>
    /// The time when the payment method was last updated.
    /// </summary>
    [JsonPropertyName("updated_at")]
    public required string UpdatedAt { get; init; }
}

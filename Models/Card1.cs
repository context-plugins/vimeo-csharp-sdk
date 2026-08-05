using System.Text.Json.Serialization;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

/// <summary>
/// Information about the card used to make the payment.
/// </summary>
public record Card1
{
    /// <summary>
    /// The billing address of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("billing_address")]
    public BillingAddress? BillingAddress { get; init; }

    /// <summary>
    /// The bank identification number of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("bin")]
    public string? Bin { get; init; }

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
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("brand")]
    public Brand? Brand { get; init; }

    /// <summary>
    /// The name of the cardholder.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cardholder_name")]
    public string? CardholderName { get; init; }

    /// <summary>
    /// The expiration month of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration_month")]
    public double? ExpirationMonth { get; init; }

    /// <summary>
    /// The expiration year of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("expiration_year")]
    public double? ExpirationYear { get; init; }

    /// <summary>
    /// The last four digits of the card.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("last_four_digits")]
    public string? LastFourDigits { get; init; }
}

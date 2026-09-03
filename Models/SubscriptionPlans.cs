using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record SubscriptionPlans
{
    /// <summary>
    /// Information about the currency in which the price of the plan is expressed.
    /// </summary>
    [JsonPropertyName("currency")]
    public required Currency Currency { get; init; }

    /// <summary>
    /// Information about the plan discount.
    /// </summary>
    [JsonPropertyName("discount")]
    public required Discount Discount { get; init; }

    /// <summary>
    /// The SKUs of the plans.
    /// </summary>
    [JsonPropertyName("id")]
    public required Id Id { get; init; }

    /// <summary>
    /// The URLs and entitlements of the associated products in the store.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata25 Metadata { get; init; }

    /// <summary>
    /// The name of the plan.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>
    /// Information about the prices associated with the plan.
    /// </summary>
    [JsonPropertyName("price")]
    public required Price Price { get; init; }

    /// <summary>
    /// The price formatted for the selected locale with the associated currency symbol.
    /// </summary>
    [JsonPropertyName("price_formatted")]
    public required PriceFormatted PriceFormatted { get; init; }

    /// <summary>
    /// Information about the plan's promotion.
    /// </summary>
    [JsonPropertyName("promotion")]
    public required Promotion Promotion { get; init; }

    /// <summary>
    /// The plan type.
    /// <para>
    /// Option descriptions:
    ///  * <c>advanced</c> - The plan type is Vimeo Advanced.
    ///  * <c>basic</c> - The plan type is Vimeo Basic.
    ///  * <c>business</c> - The plan type is Vimeo Business.
    ///  * <c>core</c> - The plan type is Vimeo Core.
    ///  * <c>creator</c> - The plan type is Vimeo Creator.
    ///  * <c>customSelfServe</c> - The plan type is Vimeo Custom.
    ///  * <c>enterprise</c> - The plan type is Vimeo Enterprise.
    ///  * <c>free</c> - The plan type is Vimeo Free.
    ///  * <c>livePremium</c> - The plan type is Vimeo Premium.
    ///  * <c>ott</c> - The plan type is Vimeo OTT.
    ///  * <c>plus</c> - The plan type is Vimeo Plus.
    ///  * <c>pro</c> - The plan type is Vimeo Pro.
    ///  * <c>proSolution</c> - The plan type is Vimeo Pro Solution.
    ///  * <c>proUnlimited</c> - The plan type is Vimeo Pro Unlimited.
    ///  * <c>production</c> - The plan type is Vimeo Production.
    ///  * <c>professional</c> - The plan type is Vimeo Professional.
    ///  * <c>standard</c> - The plan type is Vimeo Standard.
    ///  * <c>starter</c> - The plan type is Vimeo Starter.
    ///  * <c>studio</c> - The plan type is Vimeo Studio.
    ///  * <c>team</c> - The plan type is Vimeo Team.
    ///  * <c>teamLive</c> - The plan type is Vimeo Team Live.
    /// </para>
    /// </summary>
    [JsonPropertyName("tier")]
    public required Tier Tier { get; init; }

    /// <summary>
    /// The URI of the plan.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using Vimeo.Core.Models;
using Vimeo.Models.Enums;

namespace Vimeo.Models;

public record Membership
{
    /// <summary>
    /// The authenticated user's membership level.
    /// <para>
    /// Option descriptions:
    ///  * <c>Advanced</c> - The user has an Advanced subscription.
    ///  * <c>Basic</c> - The user has a Vimeo Basic subscription.
    ///  * <c>Business</c> - The user has a Vimeo Business subscription.
    ///  * <c>Business Live</c> - The user has a Vimeo Business Live subscription.
    ///  * <c>Creator</c> - The user has a Vimeo Creator subscription.
    ///  * <c>Custom</c> - The user has a Vimeo Custom subscription.
    ///  * <c>Free</c> - The user has a Free subscription.
    ///  * <c>Ott Custom</c> - The user has a Vimeo OTT Custom subscription.
    ///  * <c>Plus</c> - The user has a Vimeo Plus subscription.
    ///  * <c>Premium</c> - The user has a Vimeo Premium subscription.
    ///  * <c>Pro</c> - The user has a Vimeo Pro subscription.
    ///  * <c>Pro Live</c> - The user has a Vimeo Pro Live subscription.
    ///  * <c>Pro Unlimited</c> - The user has a Vimeo Pro Unlimited subscription.
    ///  * <c>Producer</c> - The user has a Vimeo Producer subscription.
    ///  * <c>Production</c> - The user has a Vimeo Production subscription.
    ///  * <c>Professional</c> - The user has a Vimeo Professional subscription.
    ///  * <c>Standard</c> - The user has a Vimeo Standard subscription.
    ///  * <c>Starter</c> - The user has a Vimeo Starter subscription.
    ///  * <c>Studio</c> - The user has a Vimeo Studio subscription.
    /// </para>
    /// </summary>
    [JsonPropertyName("display")]
    public required Display Display { get; init; }

    /// <summary>
    /// Information about the authenticated user's Vimeo subscription.
    /// </summary>
    [JsonPropertyName("subscription")]
    public required Subscription3 Subscription { get; init; }

    /// <summary>
    /// The authenticated user's account type.
    /// <para>
    /// Option descriptions:
    ///  * <c>advanced</c> - The user has a Vimeo Advanced account.
    ///  * <c>basic</c> - The user has a Vimeo Basic account.
    ///  * <c>business</c> - The user has a Vimeo Business account.
    ///  * <c>creator</c> - The user has a Vimeo Creator account.
    ///  * <c>custom</c> - The user has a Vimeo Custom account.
    ///  * <c>enterprise</c> - The user has a Vimeo Enterprise account.
    ///  * <c>free</c> - The user has a Vimeo Free account.
    ///  * <c>live_business</c> - The user has a Vimeo Business Live account.
    ///  * <c>live_premium</c> - The user has a Vimeo Premium account.
    ///  * <c>live_pro</c> - The user has a Vimeo Pro Live account.
    ///  * <c>ott_custom</c> - The user has a Vimeo OTT Custom account.
    ///  * <c>plus</c> - The user has a Vimeo Plus account.
    ///  * <c>pro</c> - The user has a Vimeo Pro account.
    ///  * <c>pro_unlimited</c> - The user has a Vimeo Pro Unlimited account.
    ///  * <c>producer</c> - The user has a Vimeo Producer account.
    ///  * <c>production</c> - The user has a Vimeo Production account.
    ///  * <c>professional</c> - The user has a Vimeo Professional account.
    ///  * <c>standard</c> - The user has a Vimeo Standard account.
    ///  * <c>starter</c> - The user has a Vimeo Starter account.
    ///  * <c>studio</c> - The user has a Vimeo Studio account.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type2 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

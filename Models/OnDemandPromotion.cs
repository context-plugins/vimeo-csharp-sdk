using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record OnDemandPromotion
{
    /// <summary>
    /// The type of access that the promotion grants.
    /// <para>
    /// Option descriptions:
    ///  * <c>default</c> - The promotion grants discounts on existing product offerings.
    ///  * <c>vip</c> - The promotion grants free access to On Demand content before it's released, or to access types that aren't part of the existing product offerings.
    /// </para>
    /// </summary>
    [JsonPropertyName("access_type")]
    public required AccessType AccessType { get; init; }

    /// <summary>
    /// The type of discount that the promotion provides.
    /// <para>
    /// Option descriptions:
    ///  * <c>dollars</c> - The promotion discounts a fixed amount from the full purchase price.
    ///  * <c>free</c> - The promotion discounts the full purchase price. When <b>access_type</b> is <c>vip</c>, <b>discount_type</b> is always <c>free</c>.
    ///  * <c>percent</c> - The promotion discounts a percentage of the full purchase price.
    /// </para>
    /// </summary>
    [JsonPropertyName("discount_type")]
    public required DiscountType DiscountType { get; init; }

    /// <summary>
    /// Whether the promotion grants download access to On Demand content.
    /// </summary>
    [JsonPropertyName("download")]
    public required bool Download { get; init; }

    /// <summary>
    /// The prefix string for batch codes, or the null value for single codes.
    /// </summary>
    [JsonPropertyName("label")]
    public required string? Label { get; init; }

    /// <summary>
    /// The video's metadata.
    /// </summary>
    [JsonPropertyName("metadata")]
    public required Metadata19 Metadata { get; init; }

    /// <summary>
    /// When <b>discount_type</b> is <c>percent</c>, the percentage amount that is deducted from the product price.
    /// </summary>
    [JsonPropertyName("percent_off")]
    public required double PercentOff { get; init; }

    /// <summary>
    /// The type of product to which the promotion can be applied. Only the <c>buy</c> and <c>rent</c> options are available when <b>access_type</b> is <c>vip</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>any</c> - The promotion can be applied to any product.
    ///  * <c>buy</c> - The promotion can be applied to a buyable single video.
    ///  * <c>buy_episode</c> - The promotion can be applied to a buyable single episode.
    ///  * <c>rent</c> - The promotion can be applied to a rentable single video.
    ///  * <c>rent_episode</c> - The promotion can be applied to a rentable single episode.
    ///  * <c>subscribe</c> - The promotion can be applied to a subscription.
    /// </para>
    /// </summary>
    [JsonPropertyName("product_type")]
    public required ProductType ProductType { get; init; }

    /// <summary>
    /// The amount of time that the user has access to the On Demand content after redeeming a promotional code.
    /// <para>
    /// Option descriptions:
    ///  * <c>1_week</c> - Access lasts for one week.
    ///  * <c>1_year</c> - Access lasts for one year.
    ///  * <c>3_month</c> - Access lasts for three months.
    ///  * <c>6_month</c> - Access lasts for six months.
    ///  * <c>24_hour</c> - Access lasts for 24 hours.
    ///  * <c>30_days</c> - Access lasts for 30 days.
    ///  * <c>48_hour</c> - Access lasts for 48 hours.
    ///  * <c>72_hour</c> - Access lasts for 72 hours.
    /// </para>
    /// </summary>
    [JsonPropertyName("stream_period")]
    public required StreamPeriod? StreamPeriod { get; init; }

    /// <summary>
    /// When <b>type</b> is <c>single</c>, the total number of times that the promotion can be used. When <b>type</b> is <c>batch</c> or <c>batch_prefix</c>, the total number of promo codes that have been generated.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; init; }

    /// <summary>
    /// The way in which the promotion generates promo codes.
    /// <para>
    /// Option descriptions:
    ///  * <c>batch</c> - The promotion provides a unique promotional code for each user.
    ///  * <c>batch_prefix</c> - Like <c>batch</c>, except that all codes have a similar prefix string. _This option is deprecated, yet it may still appear for some users._
    ///  * <c>single</c> - The promotion provides a single promotional code for all users.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type18 Type { get; init; }

    /// <summary>
    /// The promotion's canonical relative URI.
    /// </summary>
    [JsonPropertyName("uri")]
    public required string Uri { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Models;
using VimeoApi.Models.Enums;

namespace VimeoApi.Models;

public record OndemandPagesPromotionsRequest
{
    /// <summary>
    /// The promotion access type, which is a purchase option that isn't available in the On Demand container. Use the <b>download</b> and <b>stream_period</b> parameters to define additional characteristics for the <c>vip</c> type.
    /// <para>
    /// Option descriptions:
    ///  * <c>default</c> - The promotion grants a discount on the existing purchase options for an On Demand container.
    ///  * <c>vip</c> - The promotion grants free access to On Demand content before it's released.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("access_type")]
    public AccessType1? AccessType { get; init; }

    /// <summary>
    /// The promotion code. This parameter is ignored when the promotion type is <c>batch</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("code")]
    public string? Code { get; init; }

    /// <summary>
    /// The type of discount offered by the promotion code. When <b>access_type</b> is <c>vip</c>, the value of this parameter must be <c>free</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>free</c> - The discount reduces the price to zero.
    ///  * <c>percent</c> - The discount reduces the price by the percentage defined in the <b>percent_off</b> parameter.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("discount_type")]
    public DiscountType1? DiscountType { get; init; }

    /// <summary>
    /// Whether the promotion grants download access to On Demand content. This field is required only when the download access hasn't been defined in the On Demand container, or when <b>access_type</b> is <c>vip</c> or <b>product_type</b> is <c>buy</c>.
    /// </summary>
    [JsonPropertyName("download")]
    public required bool Download { get; init; }

    /// <summary>
    /// The time at which the promotion period ends. If this parameter has no value, the promotion never expires.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("end_time")]
    public string? EndTime { get; init; }

    /// <summary>
    /// The description of the promotion when the promotion type is <c>batch</c>. This parameter is ignored when the promotion type is <c>single</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("label")]
    public string? Label { get; init; }

    /// <summary>
    /// The percentage of the discount. This parameter is applicable only when <b>discount_type</b> is <c>percent</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("percent_off")]
    public double? PercentOff { get; init; }

    /// <summary>
    /// The type of transaction to which the promotion applies. When <b>access_type</b> is <c>default</c>, the default value is <c>any</c>. When <b>access_type</b> is <c>vip</c>, the default value is <c>rent</c> and the only valid product types are <c>buy</c> and <c>rent</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>any</c> - The promotion applies to any transaction.
    ///  * <c>buy</c> - The promotion applies only to purchased products.
    ///  * <c>buy_episode</c> - The promotion applies only to purchased episodes.
    ///  * <c>rent</c> - The promotion applies only to rented products.
    ///  * <c>rent_episode</c> - The promotion applies only to rented episodes.
    ///  * <c>subscribe</c> - The promotion applies only to subscriptions.
    /// </para>
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("product_type")]
    public ProductType1? ProductType { get; init; }

    /// <summary>
    /// The time at which the promotion period starts. If this parameter has no value, the start time defaults to the time at which the promotion was created.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("start_time")]
    public string? StartTime { get; init; }

    /// <summary>
    /// The amount of time for which the user can access On Demand content upon redeeming a promotion code. This parameter is required only when the streaming period isn't defined in the On Demand container, or when creating promotions where <b>access_type</b> is <c>vip</c> or <b>product_type</b> is <c>rent</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>1_week</c> - The user can access On Demand content for a maximum of 1 week after redeeming a promotion code.
    ///  * <c>1_year</c> - The user can access On Demand content for a maximum of 1 year after redeeming a promotion code.
    ///  * <c>3_month</c> - The user can access On Demand content for a maximum of 3 months after redeeming a promotion code.
    ///  * <c>6_month</c> - The user can access On Demand content for a maximum of 6 months after redeeming a promotion code.
    ///  * <c>24_hour</c> - The user can access On Demand content for a maximum of 24 hours after redeeming a promotion code.
    ///  * <c>30_day</c> - The user can access On Demand content for a maximum of 30 days after redeeming a promotion code.
    ///  * <c>48_hour</c> - The user can access On Demand content for a maximum of 48 hours after redeeming a promotion code.
    ///  * <c>72_hour</c> - The user can access On Demand content for a maximum of 72 hours after redeeming a promotion code.
    /// </para>
    /// </summary>
    [JsonPropertyName("stream_period")]
    public required StreamPeriod1 StreamPeriod { get; init; }

    /// <summary>
    /// When <b>type</b> is <c>batch</c>, the total number of promotions to generate. When <b>type</b> is <c>single</c>, the total number of uses of the promotion.
    /// </summary>
    [JsonPropertyName("total")]
    public required double Total { get; init; }

    /// <summary>
    /// The type of the promotion. When <b>access_type</b> is <c>vip</c>, the value for this parameter must be <c>batch</c>.
    /// <para>
    /// Option descriptions:
    ///  * <c>batch</c> - The promotion type that generates many random codes to use one time each.
    ///  * <c>single</c> - The promotion type that generates one code to use many times.
    /// </para>
    /// </summary>
    [JsonPropertyName("type")]
    public required Type37 Type { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}

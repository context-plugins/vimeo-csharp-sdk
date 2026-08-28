using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<ProductType1>))]
public sealed record ProductType1 : StringEnum<ProductType1>
{
    private ProductType1(string value) : base(value)
    {
    }

    public static readonly ProductType1 Any = new("any");

    public static readonly ProductType1 Buy = new("buy");

    public static readonly ProductType1 BuyEpisode = new("buy_episode");

    public static readonly ProductType1 Rent = new("rent");

    public static readonly ProductType1 RentEpisode = new("rent_episode");

    public static readonly ProductType1 Subscribe = new("subscribe");

    public static ProductType1 FromValue(string value) => FromValueCore(value);
}

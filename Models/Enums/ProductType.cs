using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<ProductType>))]
public sealed record ProductType : StringEnum<ProductType>
{
    private ProductType(string value) : base(value)
    {
    }

    public static readonly ProductType Any = new("any");

    public static readonly ProductType Buy = new("buy");

    public static readonly ProductType BuyEpisode = new("buy_episode");

    public static readonly ProductType Rent = new("rent");

    public static readonly ProductType RentEpisode = new("rent_episode");

    public static readonly ProductType Subscribe = new("subscribe");

    public static ProductType FromValue(string value) => FromValueCore(value);
}

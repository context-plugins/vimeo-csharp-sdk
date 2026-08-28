using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The purchase status of the product.
/// <para>
/// Option descriptions:
///  * <c>available</c> - The product is available for purchase.
///  * <c>purchased</c> - The product is already purchased.
///  * <c>unavailable</c> - The product isn't available for purchase.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status20>))]
public sealed record Status20 : StringEnum<Status20>
{
    private Status20(string value) : base(value)
    {
    }

    public static readonly Status20 Available = new("available");

    public static readonly Status20 Purchased = new("purchased");

    public static readonly Status20 Unavailable = new("unavailable");

    public static Status20 FromValue(string value) => FromValueCore(value);
}

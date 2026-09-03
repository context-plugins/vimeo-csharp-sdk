using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The purchase status of the product.
/// <para>
/// Option descriptions:
///  * <c>available</c> - The product is available for purchase.
///  * <c>purchased</c> - The product is already purchased.
///  * <c>unavailable</c> - The product isn't available for purchase.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status17>))]
public sealed record Status17 : StringEnum<Status17>
{
    private Status17(string value) : base(value)
    {
    }

    public static readonly Status17 Available = new("available");

    public static readonly Status17 Purchased = new("purchased");

    public static readonly Status17 Unavailable = new("unavailable");

    public static Status17 FromValue(string value) => FromValueCore(value);
}

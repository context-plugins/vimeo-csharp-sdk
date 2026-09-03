using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The user's streaming access to the On Demand subscription.
/// <para>
/// Option descriptions:
///  * <c>available</c> - The On Demand subscription is available for streaming.
///  * <c>purchased</c> - The On Demand subscription has been purchased.
///  * <c>restricted</c> - Streaming for the On Demand subscription is restricted.
///  * <c>unavailable</c> - The On Demand subscription is unavailable.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Stream2>))]
public sealed record Stream2 : StringEnum<Stream2>
{
    private Stream2(string value) : base(value)
    {
    }

    public static readonly Stream2 Available = new("available");

    public static readonly Stream2 Purchased = new("purchased");

    public static readonly Stream2 Restricted = new("restricted");

    public static readonly Stream2 Unavailable = new("unavailable");

    public static Stream2 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The user's streaming access to the On Demand video.
/// <para>
/// Option descriptions:
///  * <c>available</c> - The video is available for streaming.
///  * <c>purchased</c> - The user has purchased the video.
///  * <c>restricted</c> - The user isn't permitted to stream the video.
///  * <c>unavailable</c> - The video isn't available for streaming.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Stream1>))]
public sealed record Stream1 : StringEnum<Stream1>
{
    private Stream1(string value) : base(value)
    {
    }

    public static readonly Stream1 Available = new("available");

    public static readonly Stream1 Purchased = new("purchased");

    public static readonly Stream1 Restricted = new("restricted");

    public static readonly Stream1 Unavailable = new("unavailable");

    public static Stream1 FromValue(string value) => FromValueCore(value);
}

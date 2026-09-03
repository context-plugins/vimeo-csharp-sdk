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
///  * <c>unavailable</c> - The video isn't available for streaming
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<StreamEnum>))]
public sealed record StreamEnum : StringEnum<StreamEnum>
{
    private StreamEnum(string value) : base(value)
    {
    }

    public static readonly StreamEnum Available = new("available");

    public static readonly StreamEnum Purchased = new("purchased");

    public static readonly StreamEnum Restricted = new("restricted");

    public static readonly StreamEnum Unavailable = new("unavailable");

    public static StreamEnum FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The play status of the video.
/// <para>
/// Option descriptions:
///  * <c>drm_plays_exceeded</c> - The user's quota for DRM plays has been exceeded.
///  * <c>playable</c> - The video is playable.
///  * <c>purchase_required</c> - The video must be purchased.
///  * <c>restricted</c> - Playback for the video is restricted.
///  * <c>unavailable</c> - The video is unavailable.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Status3>))]
public sealed record Status3 : StringEnum<Status3>
{
    private Status3(string value) : base(value)
    {
    }

    public static readonly Status3 DrmPlaysExceeded = new("drm_plays_exceeded");

    public static readonly Status3 Playable = new("playable");

    public static readonly Status3 PurchaseRequired = new("purchase_required");

    public static readonly Status3 Restricted = new("restricted");

    public static readonly Status3 Unavailable = new("unavailable");

    public static Status3 FromValue(string value) => FromValueCore(value);
}

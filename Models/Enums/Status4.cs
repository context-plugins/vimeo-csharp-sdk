using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Status4>))]
public sealed record Status4 : StringEnum<Status4>
{
    private Status4(string value) : base(value)
    {
    }

    public static readonly Status4 DrmPlaysExceeded = new("drm_plays_exceeded");

    public static readonly Status4 Playable = new("playable");

    public static readonly Status4 PurchaseRequired = new("purchase_required");

    public static readonly Status4 Restricted = new("restricted");

    public static readonly Status4 Unavailable = new("unavailable");

    public static Status4 FromValue(string value) => FromValueCore(value);
}

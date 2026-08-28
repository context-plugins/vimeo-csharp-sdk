using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The user's download access to the On Demand video.
/// <para>
/// Option descriptions:
///  * <c>available</c> - The video is available for download.
///  * <c>purchased</c> - The user has purchased the video.
///  * <c>restricted</c> - The user isn't permitted to download the video.
///  * <c>unavailable</c> - The video isn't available for download.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Download>))]
public sealed record Download : StringEnum<Download>
{
    private Download(string value) : base(value)
    {
    }

    public static readonly Download Available = new("available");

    public static readonly Download Purchased = new("purchased");

    public static readonly Download Restricted = new("restricted");

    public static readonly Download Unavailable = new("unavailable");

    public static Download FromValue(string value) => FromValueCore(value);
}

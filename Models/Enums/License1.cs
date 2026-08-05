using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The <see href="http://creativecommons.org/licenses/">Creative Commons</see> license that the video is given under.
/// <para>
/// Option descriptions:
///  * `` - No Creative Commons license has been set for the video.
///  * <c>by</c> - The video is given under the Attribution license.
///  * <c>by-nc</c> - The video is given under the Attribution Non-Commercial license.
///  * <c>by-nc-nd</c> - The video is given under the Attribution Non-Commercial No Derivatives license.
///  * <c>by-nc-sa</c> - The video is given under the Attribution Non-Commercial Share Alike license.
///  * <c>by-nd</c> - The video is given under the Attribution No Derivatives license.
///  * <c>by-sa</c> - The video is given under the Attribution Share Alike license.
///  * <c>cc0</c> - The video is given under the Public Domain Dedication license.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<License1>))]
public sealed record License1 : StringEnum<License1>
{
    private License1(string value) : base(value)
    {
    }

    public static readonly License1 By = new("by");

    public static readonly License1 ByNc = new("by-nc");

    public static readonly License1 ByNcNd = new("by-nc-nd");

    public static readonly License1 ByNcSa = new("by-nc-sa");

    public static readonly License1 ByNd = new("by-nd");

    public static readonly License1 BySa = new("by-sa");

    public static readonly License1 Cc0 = new("cc0");

    public static License1 FromValue(string value) => FromValueCore(value);
}

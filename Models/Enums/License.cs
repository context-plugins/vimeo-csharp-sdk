using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The <see href="http://creativecommons.org/licenses/">Creative Commons</see> license that the user has set to be the default.
/// <para>
/// Option descriptions:
///  * <c>by</c> - The video is given under the Attribution license.
///  * <c>by-nc</c> - The video is given under the Attribution Non-Commercial license.
///  * <c>by-nc-nd</c> - The video is given under the Attribution Non-Commercial No Derivatives license.
///  * <c>by-nc-sa</c> - The video is given under the Attribution Non-Commercial Share Alike license.
///  * <c>by-nd</c> - The video is given under the Attribution No Derivatives license.
///  * <c>by-sa</c> - The video is given under the Attribution Share Alike license.
///  * <c>cc0</c> - The video is given under the Public Domain Dedication license.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<License>))]
public sealed record License : StringEnum<License>
{
    private License(string value) : base(value)
    {
    }

    public static readonly License By = new("by");

    public static readonly License ByNc = new("by-nc");

    public static readonly License ByNcNd = new("by-nc-nd");

    public static readonly License ByNcSa = new("by-nc-sa");

    public static readonly License ByNd = new("by-nd");

    public static readonly License BySa = new("by-sa");

    public static readonly License Cc0 = new("cc0");

    public static License FromValue(string value) => FromValueCore(value);
}

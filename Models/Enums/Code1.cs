using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of Creative Commons license.
/// <para>
/// Option descriptions:
///  * <c>by</c> - Attribution.
///  * <c>by-nc</c> - Attribution Non-Commercial.
///  * <c>by-nc-nd</c> - Attribution Non-Commercial No Derivatives.
///  * <c>by-nc-sa</c> - Attribution Non-Commercial Share Alike.
///  * <c>by-nd</c> - Attribution No Derivatives.
///  * <c>by-sa</c> - Attribution Share Alike.
///  * <c>cc0</c> - Public Domain Dedication.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Code1>))]
public sealed record Code1 : StringEnum<Code1>
{
    private Code1(string value) : base(value)
    {
    }

    public static readonly Code1 By = new("by");

    public static readonly Code1 ByNc = new("by-nc");

    public static readonly Code1 ByNcNd = new("by-nc-nd");

    public static readonly Code1 ByNcSa = new("by-nc-sa");

    public static readonly Code1 ByNd = new("by-nd");

    public static readonly Code1 BySa = new("by-sa");

    public static readonly Code1 Cc0 = new("cc0");

    public static Code1 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The Creative Commons license under which the video is offered.
/// <para>
/// Option descriptions:
///  * <c>by</c> - The video is offered under CC BY, or the attibution-only license.
///  * <c>by-nc</c> - The video is offered under CC BY-NC, or the Attribution-NonCommercial license.
///  * <c>by-nc-nd</c> - The video is offered under CC BY-NC-ND, or the Attribution-NonCommercian-NoDerivs license.
///  * <c>by-nc-sa</c> - The video is offered under CC BY-NC-SA, or the Attribution-NonCommercial-ShareAlike licence.
///  * <c>by-nd</c> - The video is offered under CC BY-ND, or the Attribution-NoDerivs license.
///  * <c>by-sa</c> - The video is offered under CC BY-SA, or the Attribution-ShareAlike license.
///  * <c>cc0</c> - The video is offered under CC0, or public domain, videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<License4>))]
public sealed record License4 : StringEnum<License4>
{
    private License4(string value) : base(value)
    {
    }

    public static readonly License4 By = new("by");

    public static readonly License4 ByNc = new("by-nc");

    public static readonly License4 ByNcNd = new("by-nc-nd");

    public static readonly License4 ByNcSa = new("by-nc-sa");

    public static readonly License4 ByNd = new("by-nd");

    public static readonly License4 BySa = new("by-sa");

    public static readonly License4 Cc0 = new("cc0");

    public static License4 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The default video sort order of the portfolio.
/// <para>
/// Option descriptions:
///  * <c>alphabetical</c> - The default sort order is alphabetical by name.
///  * <c>clips</c> - The default sort order is video creation date.
///  * <c>modified</c> - The default sort order is the order in which the videos were modified.
///  * <c>recent</c> - The default sort order is the order in which the videos were added.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Sort1>))]
public sealed record Sort1 : StringEnum<Sort1>
{
    private Sort1(string value) : base(value)
    {
    }

    public static readonly Sort1 Alphabetical = new("alphabetical");

    public static readonly Sort1 Clips = new("clips");

    public static readonly Sort1 Modified = new("modified");

    public static readonly Sort1 Recent = new("recent");

    public static Sort1 FromValue(string value) => FromValueCore(value);
}

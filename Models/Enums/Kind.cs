using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The node kind.
/// <para>
/// Option descriptions:
///  * <c>category</c> - A grouping node; its children reference it via <c>parent_id</c>.
///  * <c>external</c> - Handed off to a dedicated form (see <c>external_url</c>), not POST-able here.
///  * <c>reason</c> - A submittable leaf; its <c>id</c> is the opaque reason UUID to POST.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Kind>))]
public sealed record Kind : StringEnum<Kind>
{
    private Kind(string value) : base(value)
    {
    }

    public static readonly Kind Category = new("category");

    public static readonly Kind External = new("external");

    public static readonly Kind Reason = new("reason");

    public static Kind FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// Who can access the group.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the group. This privacy setting appears as <c>Public</c> on the Vimeo front end.
///  * <c>members</c> - Only group members can access the group.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<View5>))]
public sealed record View5 : StringEnum<View5>
{
    private View5(string value) : base(value)
    {
    }

    public static readonly View5 Anybody = new("anybody");

    public static readonly View5 Members = new("members");

    public static View5 FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// Who can add videos to the group.
/// <para>
/// Option descriptions:
///  * <c>all</c> - Anyone can add videos to the group.
///  * <c>members</c> - Only group members can add videos to the group.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Videos7>))]
public sealed record Videos7 : StringEnum<Videos7>
{
    private Videos7(string value) : base(value)
    {
    }

    public static readonly Videos7 All = new("all");

    public static readonly Videos7 Members = new("members");

    public static Videos7 FromValue(string value) => FromValueCore(value);
}

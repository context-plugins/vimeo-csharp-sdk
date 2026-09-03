using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// Who can comment on the group.
/// <para>
/// Option descriptions:
///  * <c>all</c> - Anyone can comment on the group.
///  * <c>members</c> - Only group members can comment on the group.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Comment2>))]
public sealed record Comment2 : StringEnum<Comment2>
{
    private Comment2(string value) : base(value)
    {
    }

    public static readonly Comment2 All = new("all");

    public static readonly Comment2 Members = new("members");

    public static Comment2 FromValue(string value) => FromValueCore(value);
}

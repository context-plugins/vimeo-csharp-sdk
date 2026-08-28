using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// Who can invite new members to the group.
/// <para>
/// Option descriptions:
///  * <c>all</c> - Anyone can invite new members to the group.
///  * <c>members</c> - Only group members can invite new members to the group.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Invite2>))]
public sealed record Invite2 : StringEnum<Invite2>
{
    private Invite2(string value) : base(value)
    {
    }

    public static readonly Invite2 All = new("all");

    public static readonly Invite2 Members = new("members");

    public static Invite2 FromValue(string value) => FromValueCore(value);
}

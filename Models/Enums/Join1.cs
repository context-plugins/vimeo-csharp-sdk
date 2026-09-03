using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// Who can join the group.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can join the group.
///  * <c>members</c> - Only people with a Vimeo account can join the group.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Join1>))]
public sealed record Join1 : StringEnum<Join1>
{
    private Join1(string value) : base(value)
    {
    }

    public static readonly Join1 Anybody = new("anybody");

    public static readonly Join1 Members = new("members");

    public static Join1 FromValue(string value) => FromValueCore(value);
}

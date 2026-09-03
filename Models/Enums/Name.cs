using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// How the embeddable player handles the video title.
/// <para>
/// Option descriptions:
///  * <c>hide</c> - The title is hidden.
///  * <c>show</c> - The title is shown.
///  * <c>user</c> - The title can be toggled to <c>show</c> or <c>hide</c> by the user.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Name>))]
public sealed record Name : StringEnum<Name>
{
    private Name(string value) : base(value)
    {
    }

    public static readonly Name Hide = new("hide");

    public static readonly Name Show = new("show");

    public static readonly Name User = new("user");

    public static Name FromValue(string value) => FromValueCore(value);
}

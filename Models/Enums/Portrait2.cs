using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// How to handle the owner portrait in the title bar of the embeddable player.
/// <para>
/// Option descriptions:
///  * <c>hide</c> - Hide the portrait.
///  * <c>show</c> - Show the portrait.
///  * <c>user</c> - Enable the user to decide.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Portrait2>))]
public sealed record Portrait2 : StringEnum<Portrait2>
{
    private Portrait2(string value) : base(value)
    {
    }

    public static readonly Portrait2 Hide = new("hide");

    public static readonly Portrait2 Show = new("show");

    public static readonly Portrait2 User = new("user");

    public static Portrait2 FromValue(string value) => FromValueCore(value);
}

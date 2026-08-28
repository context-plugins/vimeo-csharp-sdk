using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// How to handle the video title in the title bar of the embeddable player.
/// <para>
/// Option descriptions:
///  * <c>hide</c> - Hide the video title.
///  * <c>show</c> - Show the video title.
///  * <c>user</c> - Enable the user to decide.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Name1>))]
public sealed record Name1 : StringEnum<Name1>
{
    private Name1(string value) : base(value)
    {
    }

    public static readonly Name1 Hide = new("hide");

    public static readonly Name1 Show = new("show");

    public static readonly Name1 User = new("user");

    public static Name1 FromValue(string value) => FromValueCore(value);
}

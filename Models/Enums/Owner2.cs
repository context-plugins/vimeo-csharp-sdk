using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// How to handle the owner information in the title bar of the embeddable player.
/// <para>
/// Option descriptions:
///  * <c>hide</c> - Hide the owner info.
///  * <c>show</c> - Show the owner info.
///  * <c>user</c> - Enable the user to decide.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Owner2>))]
public sealed record Owner2 : StringEnum<Owner2>
{
    private Owner2(string value) : base(value)
    {
    }

    public static readonly Owner2 Hide = new("hide");

    public static readonly Owner2 Show = new("show");

    public static readonly Owner2 User = new("user");

    public static Owner2 FromValue(string value) => FromValueCore(value);
}

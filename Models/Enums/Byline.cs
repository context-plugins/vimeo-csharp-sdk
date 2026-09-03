using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// How the embeddable player handles the video owner's information.
/// <para>
/// Option descriptions:
///  * <c>hide</c> - The owner's information is hidden.
///  * <c>show</c> - The owner's information is shown.
///  * <c>user</c> - The owner's information can be toggled to <c>show</c> or <c>hide</c> by the user.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Byline>))]
public sealed record Byline : StringEnum<Byline>
{
    private Byline(string value) : base(value)
    {
    }

    public static readonly Byline Hide = new("hide");

    public static readonly Byline Show = new("show");

    public static readonly Byline User = new("user");

    public static Byline FromValue(string value) => FromValueCore(value);
}

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
[JsonConverter(typeof(StringEnumConverter<Owner>))]
public sealed record Owner : StringEnum<Owner>
{
    private Owner(string value) : base(value)
    {
    }

    public static readonly Owner Hide = new("hide");

    public static readonly Owner Show = new("show");

    public static readonly Owner User = new("user");

    public static Owner FromValue(string value) => FromValueCore(value);
}

using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// How the embeddable player handles the video owner's portrait.
/// <para>
/// Option descriptions:
///  * <c>hide</c> - The owner's portrait is hidden
///  * <c>show</c> - The owner's portrait is shown.
///  * <c>user</c> - The owner's portrait can be toggled to <c>show</c> or <c>hide</c> by the user.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Portrait>))]
public sealed record Portrait : StringEnum<Portrait>
{
    private Portrait(string value) : base(value)
    {
    }

    public static readonly Portrait Hide = new("hide");

    public static readonly Portrait Show = new("show");

    public static readonly Portrait User = new("user");

    public static Portrait FromValue(string value) => FromValueCore(value);
}

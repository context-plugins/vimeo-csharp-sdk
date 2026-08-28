using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// How the embeddable player handles the video owner's portrait.
/// <para>
/// Option descriptions:
///  * <c>hide</c> - The owner's portrait is hidden.
///  * <c>show</c> - The owner's portrait is shown.
///  * <c>user</c> - The owner's portrait can be toggled to <c>show</c> or <c>hide</c> by the user.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Portrait1>))]
public sealed record Portrait1 : StringEnum<Portrait1>
{
    private Portrait1(string value) : base(value)
    {
    }

    public static readonly Portrait1 Hide = new("hide");

    public static readonly Portrait1 Show = new("show");

    public static readonly Portrait1 User = new("user");

    public static Portrait1 FromValue(string value) => FromValueCore(value);
}

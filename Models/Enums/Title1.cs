using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// How the embeddable player handles the video title.
/// <para>
/// Option descriptions:
///  * <c>hide</c> - The title is hidden.
///  * <c>show</c> - The title is shown.
///  * <c>user</c> - The title can be toggled to <c>show</c> or <c>hide</c> by the user.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Title1>))]
public sealed record Title1 : StringEnum<Title1>
{
    private Title1(string value) : base(value)
    {
    }

    public static readonly Title1 Hide = new("hide");

    public static readonly Title1 Show = new("show");

    public static readonly Title1 User = new("user");

    public static Title1 FromValue(string value) => FromValueCore(value);
}

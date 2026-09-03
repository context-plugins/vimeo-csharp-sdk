using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The end screen type.
/// <para>
/// Option descriptions:
///  * <c>beginning</c> - The end screen is a thumbnail.
///  * <c>custom</c> - The end screen is custom.
///  * <c>email</c> - The end screen is an email form.
///  * <c>image</c> - The end screen is an image.
///  * <c>link</c> - The end screen is a link.
///  * <c>loop</c> - The end screen is a loop.
///  * <c>nothing</c> - There is no end screen.
///  * <c>share</c> - The end screen is a share button.
///  * <c>text</c> - The end screen is text.
///  * <c>threevideos</c> - The end screen is three video suggestions.
///  * <c>videos</c> - The end screen is video suggestions.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type34>))]
public sealed record Type34 : StringEnum<Type34>
{
    private Type34(string value) : base(value)
    {
    }

    public static readonly Type34 Beginning = new("beginning");

    public static readonly Type34 Custom = new("custom");

    public static readonly Type34 Email = new("email");

    public static readonly Type34 Image = new("image");

    public static readonly Type34 Link = new("link");

    public static readonly Type34 Loop = new("loop");

    public static readonly Type34 Nothing = new("nothing");

    public static readonly Type34 Share = new("share");

    public static readonly Type34 Text = new("text");

    public static readonly Type34 Threevideos = new("threevideos");

    public static readonly Type34 Videos = new("videos");

    public static Type34 FromValue(string value) => FromValueCore(value);
}

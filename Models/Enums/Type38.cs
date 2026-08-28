using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Type38>))]
public sealed record Type38 : StringEnum<Type38>
{
    private Type38(string value) : base(value)
    {
    }

    public static readonly Type38 Beginning = new("beginning");

    public static readonly Type38 Custom = new("custom");

    public static readonly Type38 Email = new("email");

    public static readonly Type38 Image = new("image");

    public static readonly Type38 Link = new("link");

    public static readonly Type38 Loop = new("loop");

    public static readonly Type38 Nothing = new("nothing");

    public static readonly Type38 Share = new("share");

    public static readonly Type38 Text = new("text");

    public static readonly Type38 Threevideos = new("threevideos");

    public static readonly Type38 Videos = new("videos");

    public static Type38 FromValue(string value) => FromValueCore(value);
}

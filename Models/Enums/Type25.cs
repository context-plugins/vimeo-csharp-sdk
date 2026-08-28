using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The elements that appear after the video ends.
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
[JsonConverter(typeof(StringEnumConverter<Type25>))]
public sealed record Type25 : StringEnum<Type25>
{
    private Type25(string value) : base(value)
    {
    }

    public static readonly Type25 Beginning = new("beginning");

    public static readonly Type25 Custom = new("custom");

    public static readonly Type25 Email = new("email");

    public static readonly Type25 Image = new("image");

    public static readonly Type25 Link = new("link");

    public static readonly Type25 Loop = new("loop");

    public static readonly Type25 Nothing = new("nothing");

    public static readonly Type25 Share = new("share");

    public static readonly Type25 Text = new("text");

    public static readonly Type25 Threevideos = new("threevideos");

    public static readonly Type25 Videos = new("videos");

    public static Type25 FromValue(string value) => FromValueCore(value);
}

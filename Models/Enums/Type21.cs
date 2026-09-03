using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

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
[JsonConverter(typeof(StringEnumConverter<Type21>))]
public sealed record Type21 : StringEnum<Type21>
{
    private Type21(string value) : base(value)
    {
    }

    public static readonly Type21 Beginning = new("beginning");

    public static readonly Type21 Custom = new("custom");

    public static readonly Type21 Email = new("email");

    public static readonly Type21 Image = new("image");

    public static readonly Type21 Link = new("link");

    public static readonly Type21 Loop = new("loop");

    public static readonly Type21 Nothing = new("nothing");

    public static readonly Type21 Share = new("share");

    public static readonly Type21 Text = new("text");

    public static readonly Type21 Threevideos = new("threevideos");

    public static readonly Type21 Videos = new("videos");

    public static Type21 FromValue(string value) => FromValueCore(value);
}

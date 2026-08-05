using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The type of the video outro.
/// <para>
/// Option descriptions:
///  * <c>beginning</c> - The outro is a thumbnail.
///  * <c>custom</c> - The outro is custom.
///  * <c>email</c> - The outro is an email form.
///  * <c>image</c> - The outro is an image.
///  * <c>link</c> - The outro is a link.
///  * <c>loop</c> - The outro is a loop.
///  * <c>nothing</c> - There is no outro.
///  * <c>share</c> - The outro is a share button.
///  * <c>text</c> - The outro is text.
///  * <c>threevideos</c> - The outro is three video suggestions.
///  * <c>videos</c> - The outro is video suggestions.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<OutroType>))]
public sealed record OutroType : StringEnum<OutroType>
{
    private OutroType(string value) : base(value)
    {
    }

    public static readonly OutroType Beginning = new("beginning");

    public static readonly OutroType Custom = new("custom");

    public static readonly OutroType Email = new("email");

    public static readonly OutroType Image = new("image");

    public static readonly OutroType Link = new("link");

    public static readonly OutroType Loop = new("loop");

    public static readonly OutroType Nothing = new("nothing");

    public static readonly OutroType Share = new("share");

    public static readonly OutroType Text = new("text");

    public static readonly OutroType Threevideos = new("threevideos");

    public static readonly OutroType Videos = new("videos");

    public static OutroType FromValue(string value) => FromValueCore(value);
}

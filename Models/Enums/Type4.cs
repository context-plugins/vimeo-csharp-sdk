using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// How the embeddable player handles the end screen.
/// <para>
/// Option descriptions:
///  * <c>empty</c> - The end screen is empty.
///  * <c>loop</c> - The end screen loops the video playback.
///  * <c>share</c> - The end screen includes sharing options.
///  * <c>thumbnail</c> - The end screen includes the thumbnail of the video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type4>))]
public sealed record Type4 : StringEnum<Type4>
{
    private Type4(string value) : base(value)
    {
    }

    public static readonly Type4 Empty = new("empty");

    public static readonly Type4 Loop = new("loop");

    public static readonly Type4 Share = new("share");

    public static readonly Type4 Thumbnail = new("thumbnail");

    public static Type4 FromValue(string value) => FromValueCore(value);
}

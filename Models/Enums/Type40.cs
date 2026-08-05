using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The end screen type.
/// <para>
/// Option descriptions:
///  * <c>empty</c> - The end screen is empty.
///  * <c>loop</c> - The end screen loops the video playback.
///  * <c>share</c> - The end screen includes sharing options.
///  * <c>thumbnail</c> - The end screen includes the thumbnail of the video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Type40>))]
public sealed record Type40 : StringEnum<Type40>
{
    private Type40(string value) : base(value)
    {
    }

    public static readonly Type40 Empty = new("empty");

    public static readonly Type40 Loop = new("loop");

    public static readonly Type40 Share = new("share");

    public static readonly Type40 Thumbnail = new("thumbnail");

    public static Type40 FromValue(string value) => FromValueCore(value);
}

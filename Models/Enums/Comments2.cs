using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The video's comment permission setting.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can comment on the video.
///  * <c>contacts</c> - Only contacts can comment on the video.
///  * <c>nobody</c> - No one can comment on the video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Comments2>))]
public sealed record Comments2 : StringEnum<Comments2>
{
    private Comments2(string value) : base(value)
    {
    }

    public static readonly Comments2 Anybody = new("anybody");

    public static readonly Comments2 Contacts = new("contacts");

    public static readonly Comments2 Nobody = new("nobody");

    public static Comments2 FromValue(string value) => FromValueCore(value);
}

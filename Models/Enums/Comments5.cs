using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The privacy level required to comment on the video.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can comment on the video.
///  * <c>contacts</c> - Only the video owner's contacts can comment on the video.
///  * <c>nobody</c> - No one can comment on the video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Comments5>))]
public sealed record Comments5 : StringEnum<Comments5>
{
    private Comments5(string value) : base(value)
    {
    }

    public static readonly Comments5 Anybody = new("anybody");

    public static readonly Comments5 Contacts = new("contacts");

    public static readonly Comments5 Nobody = new("nobody");

    public static Comments5 FromValue(string value) => FromValueCore(value);
}

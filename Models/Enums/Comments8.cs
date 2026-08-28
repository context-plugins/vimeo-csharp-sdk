using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The privacy level required to comment on the video.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can comment on the video.
///  * <c>contacts</c> - Only the owner's contacts can comment on the video.
///  * <c>nobody</c> - No one can comment on the video.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Comments8>))]
public sealed record Comments8 : StringEnum<Comments8>
{
    private Comments8(string value) : base(value)
    {
    }

    public static readonly Comments8 Anybody = new("anybody");

    public static readonly Comments8 Contacts = new("contacts");

    public static readonly Comments8 Nobody = new("nobody");

    public static Comments8 FromValue(string value) => FromValueCore(value);
}

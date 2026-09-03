using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The authenticated user's privacy preference for comments.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can comment on the user's videos.
///  * <c>contacts</c> - Only contacts can comment on the user's videos.
///  * <c>nobody</c> - No one can comment on the user's videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Comments>))]
public sealed record Comments : StringEnum<Comments>
{
    private Comments(string value) : base(value)
    {
    }

    public static readonly Comments Anybody = new("anybody");

    public static readonly Comments Contacts = new("contacts");

    public static readonly Comments Nobody = new("nobody");

    public static Comments FromValue(string value) => FromValueCore(value);
}

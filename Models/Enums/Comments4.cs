using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// Who can comment on the user's video uploads by default.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can comment.
///  * <c>contacts</c> - Only the user's contacts can comment.
///  * <c>nobody</c> - No one can comment.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Comments4>))]
public sealed record Comments4 : StringEnum<Comments4>
{
    private Comments4(string value) : base(value)
    {
    }

    public static readonly Comments4 Anybody = new("anybody");

    public static readonly Comments4 Contacts = new("contacts");

    public static readonly Comments4 Nobody = new("nobody");

    public static Comments4 FromValue(string value) => FromValueCore(value);
}

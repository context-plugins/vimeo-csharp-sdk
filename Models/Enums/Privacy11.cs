using System.Text.Json.Serialization;
using VimeoApi.Core.Enum;

namespace VimeoApi.Models.Enums;

/// <summary>
/// The privacy level of the showcase.
/// <para>
/// Option descriptions:
///  * <c>anybody</c> - Anyone can access the showcase, either on Vimeo or through an embed.
///  * <c>embed_only</c> - The showcase doesn't appear on Vimeo, but it can be embedded on other sites.
///  * <c>nobody</c> - No one can access the showcase, including the authenticated user.
///  * <c>password</c> - Only those with the password can access the showcase.
///  * <c>team</c> - Only members of the authenticated user's team can access the showcase.
///  * <c>unlisted</c> - The showcase can't be accessed if the URL omits its unlisted hash.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Privacy11>))]
public sealed record Privacy11 : StringEnum<Privacy11>
{
    private Privacy11(string value) : base(value)
    {
    }

    public static readonly Privacy11 Anybody = new("anybody");

    public static readonly Privacy11 EmbedOnly = new("embed_only");

    public static readonly Privacy11 Nobody = new("nobody");

    public static readonly Privacy11 Password = new("password");

    public static readonly Privacy11 Team = new("team");

    public static readonly Privacy11 Unlisted = new("unlisted");

    public static Privacy11 FromValue(string value) => FromValueCore(value);
}

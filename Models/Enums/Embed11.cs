using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The privacy for the user's embedded videos. The <c>whitelist</c> value enables you to define all valid embeddable domains. See our <see href="https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy">Interacting with Videos</see> guide for details on adding and removing domains.
/// <para>
/// Option descriptions:
///  * <c>private</c> - The videos can't be embedded on any domain.
///  * <c>public</c> - The videos can be embedded on any domain.
///  * <c>whitelist</c> - The videos can be embedded on the specified domains only.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Embed11>))]
public sealed record Embed11 : StringEnum<Embed11>
{
    private Embed11(string value) : base(value)
    {
    }

    public static readonly Embed11 Private = new("private");

    public static readonly Embed11 Public = new("public");

    public static readonly Embed11 Whitelist = new("whitelist");

    public static Embed11 FromValue(string value) => FromValueCore(value);
}

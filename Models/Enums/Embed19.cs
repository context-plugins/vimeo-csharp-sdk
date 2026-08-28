using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The video's embed setting. Specify the <c>whitelist</c> value to restrict embedding to a specific set of domains. For more information, see our <see href="https://developer.vimeo.com/api/guides/videos/interact#set-off-site-privacy">Interacting with Videos</see> guide.
/// <para>
/// Option descriptions:
///  * <c>private</c> - The video can't be embedded.
///  * <c>public</c> - The video can be embedded.
///  * <c>whitelist</c> - The video can be embedded on the specified domains only.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Embed19>))]
public sealed record Embed19 : StringEnum<Embed19>
{
    private Embed19(string value) : base(value)
    {
    }

    public static readonly Embed19 Private = new("private");

    public static readonly Embed19 Public = new("public");

    public static readonly Embed19 Whitelist = new("whitelist");

    public static Embed19 FromValue(string value) => FromValueCore(value);
}

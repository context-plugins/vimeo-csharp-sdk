using System.Text.Json.Serialization;
using Vimeo.Core.Enum;

namespace Vimeo.Models.Enums;

/// <summary>
/// The authenticated user's privacy preference for embeds.
/// <para>
/// Option descriptions:
///  * <c>private</c> - Only the user can embed their own videos.
///  * <c>public</c> - Anyone can embed the user's videos.
///  * <c>whitelist</c> - Only specified users can embed the user's videos.
/// </para>
/// </summary>
[JsonConverter(typeof(StringEnumConverter<Embed>))]
public sealed record Embed : StringEnum<Embed>
{
    private Embed(string value) : base(value)
    {
    }

    public static readonly Embed Private = new("private");

    public static readonly Embed Public = new("public");

    public static readonly Embed Whitelist = new("whitelist");

    public static Embed FromValue(string value) => FromValueCore(value);
}
